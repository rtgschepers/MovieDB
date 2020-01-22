using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    class GenreController
    {
        public ObservableCollection<Genre> getGenres()
        {
            using (var db = new MovieDBEntities())
                return new ObservableCollection<Genre>(db.Genres.Include("Movies"));
        }
        
        public ObservableCollection<Genre> getGenresNotInMovie(Movie movie)
        {
            using (var db = new MovieDBEntities())
            {
                var genre = db.Genres.ToList();
                foreach (var g in new List<Genre>(genre))
                    if (g.Movies.Select(m => m.id).Contains(movie.id))
                        genre.Remove(g);
                return new ObservableCollection<Genre>(genre);
            }
        }

        public void saveGenre(Genre genre)
        {
            using (var db = new MovieDBEntities())
            {
                db.Genres.AddOrUpdate(genre);
                db.SaveChanges();
            }
        }

        public void deleteGenre(Genre genre)
        {
            using (var db = new MovieDBEntities())
            {
                db.Genres.Attach(genre);
                db.Genres.Remove(genre);
                db.SaveChanges();
            }
        }

    }
}
