using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class frmMovieInfo : Form
    {
        private Movie movie;
        private MovieController mc;
        private ActorController ac;
        private GenreController gc;

        public frmMovieInfo()
        {
            InitializeComponent();

            this.movie = new Movie();
            this.movie.release_date = DateTime.Now;

            mc = new MovieController();
            ac = new ActorController();
            gc = new GenreController();
        }

        public frmMovieInfo(Movie movie) : this()
        {
            this.movie = movie;
        }

        private void frmMovieInfo_Load(object sender, EventArgs e)
        {
            txbTitle.DataBindings.Add("Text", movie, "title");
            nudRuntime.DataBindings.Add("Value", movie, "runtime", true);
            dtpReleaseDate.DataBindings.Add("Value", movie, "release_date", true);
            nudRating.DataBindings.Add("Value", movie, "rating", true);

            bsActors.DataSource = ac.getActorsNotInMovie(movie);
            bsGenres.DataSource = gc.getGenresNotInMovie(movie);
            bsMovieActors.DataSource = movie.Actors.ToList();
            bsMovieGenres.DataSource = movie.Genres.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mc.saveMovie(movie);
            this.Close();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            var actor = (Actor)lbActors.SelectedItem;
            bsActors.Remove(actor);
            bsMovieActors.Add(actor);
            movie.Actors.Add(actor);
        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            var actor = (Actor)lbMovieActors.SelectedItem;
            bsActors.Add(actor);
            bsMovieActors.Remove(actor);
            movie.Actors.Remove(actor);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var genre = (Genre)lbGenres.SelectedItem;
            bsGenres.Remove(genre);
            bsMovieGenres.Add(genre);
            movie.Genres.Add(genre);
        }

        private void btnRemoveGenre_Click(object sender, EventArgs e)
        {
            var genre = (Genre)lbMovieGenres.SelectedItem;
            bsGenres.Add(genre);
            bsMovieGenres.Remove(genre);
            movie.Genres.Remove(genre);
        }
    }
}
