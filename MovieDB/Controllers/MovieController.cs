using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    class MovieController
    {
        public ObservableCollection<Movie> getMovies()
        {
            using (var db = new MovieDBEntities())
                return new ObservableCollection<Movie>(db.Movies.Include("Actors").Include("Genres"));
        }

        public void saveMovie(Movie movie)
        {
            using (var db = new MovieDBEntities())
            {
                // Retrieve movie from database or create new one if not found
                var dbMovie = db.Movies.Include("Actors").Include("Genres").Where(m => m.id == movie.id).SingleOrDefault<Movie>() ?? new Movie();

                // Overwrite property values
                dbMovie.rating = movie.rating;
                dbMovie.release_date = movie.release_date;
                dbMovie.runtime = movie.runtime;
                dbMovie.title = movie.title;

                /* From the retrieved movie's actor list, get all actors that are not in the edited movie's actor list.
                 * We do this because we no longer want them to be in the retrieved movie's actor list, but have to remove them manually.
                 * This is done by comparing all id's in both lists. Like a loop in a loop.
                 * The exact same is done for the genres.
                 */
                var deletedActors = dbMovie.Actors.Where(a1 => movie.Actors.All(a2 => a1.id != a2.id)).ToList();
                var deletedGenres = dbMovie.Genres.Where(g1 => movie.Genres.All(g2 => g1.id != g2.id)).ToList();

                /* From the edited movie's actor list, get all actors that are not in the retrieved movie's actor list.
                 * We do this because we want those actors to be in the retrieved movie's actor list aswell, but have to add them manually.
                 * This is done by comparing all id's in both lists. Like a loop in a loop.
                 * The exact same is done for the genres.
                 */
                var addedActors = movie.Actors.Where(a1 => dbMovie.Actors.All(a2 => a1.id != a2.id)).ToList();
                var addedGenres = movie.Genres.Where(g1 => dbMovie.Genres.All(g2 => g1.id != g2.id)).ToList();

                // Remove the actors that are not in the edited movie from the retrieved movie
                deletedActors.ForEach(a => dbMovie.Actors.Remove(a));
                deletedGenres.ForEach(g => dbMovie.Genres.Remove(g));

                // Add the new actors to the actors list of the retrieved movie
                foreach (Actor a in addedActors)
                {
                    if (db.Entry(a).State == EntityState.Detached)
                        db.Actors.Attach(a);
                    dbMovie.Actors.Add(a);
                }

                // Add the new genres to the genres list of the retrieved movie
                foreach (Genre g in addedGenres)
                {
                    if (db.Entry(g).State == EntityState.Detached)
                        db.Genres.Attach(g);
                    dbMovie.Genres.Add(g);
                }

                // Check if a new movie if made
                if (movie.id == default(int))
                    db.Movies.Add(dbMovie);

                // Save the changes
                db.SaveChanges();
            }
        }

        public void deleteMovie(Movie movie)
        {
            using (var db = new MovieDBEntities())
            {
                db.Movies.Attach(movie);
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
        }
    }
}
