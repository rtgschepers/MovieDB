using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    class ActorController
    {
        public ObservableCollection<Actor> getActors()
        {
            using (var db = new MovieDBEntities())
                return new ObservableCollection<Actor>(db.Actors.Include("Movies"));
        }

        public ObservableCollection<Actor> getActorsNotInMovie(Movie movie)
        {
            using (var db = new MovieDBEntities())
            {
                var actors = db.Actors.ToList();
                foreach (var a in new List<Actor>(actors))
                    if (a.Movies.Select(m => m.id).Contains(movie.id))
                        actors.Remove(a);
                return new ObservableCollection<Actor>(actors);
            }
        }

        public void saveActor(Actor actor)
        {
            using (var db = new MovieDBEntities())
            {
                db.Actors.AddOrUpdate(actor);
                db.SaveChanges();
            }
        }

        public void deleteActor(Actor actor)
        {
            using (var db = new MovieDBEntities())
            {
                db.Actors.Attach(actor);
                db.Actors.Remove(actor);
                db.SaveChanges();
            }
        }
    }
}
