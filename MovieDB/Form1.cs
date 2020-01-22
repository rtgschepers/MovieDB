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
    public partial class Form1 : Form
    {
        ActorController ac = new ActorController();
        MovieController mc = new MovieController();
        GenreController gc = new GenreController();

        public Form1()
        {
            InitializeComponent();

            dgvActors.AutoGenerateColumns = true;
            dgvMovies.AutoGenerateColumns = true;
            dgvGenres.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh(sender, e);
        }

        private void refresh(object sender, EventArgs e)
        {
            bsActors.DataSource = ac.getActors();
            bsMovies.DataSource = mc.getMovies();
            bsGenres.DataSource = gc.getGenres();
            
            dgvActors.Columns["movies"].Visible = false;
            dgvActors.Columns["full_name"].Visible = false;
            dgvMovies.Columns["actors"].Visible = false;
            dgvMovies.Columns["genres"].Visible = false;
            dgvGenres.Columns["movies"].Visible = false;
        }

        /*
         * CREATE FUNCTIONS
         */
        private void btnCreateActor_Click(object sender, EventArgs e)
        {
            frmActorInfo fai = new frmActorInfo();
            fai.Show();
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            frmMovieInfo fai = new frmMovieInfo();
            fai.Show();
        }

        private void btnCreateGenre_Click(object sender, EventArgs e)
        {
            frmGenreInfo fgi = new frmGenreInfo();
            fgi.Show();
        }

        /*
         * UPDATE FUNCTIONS
         */
        private void btnUpdateActor_Click(object sender, EventArgs e)
        {
            var actor = (Actor)dgvActors.CurrentRow.DataBoundItem;
            frmActorInfo ia = new frmActorInfo(actor);
            ia.Show();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            var movie = (Movie)dgvMovies.CurrentRow.DataBoundItem;
            frmMovieInfo ia = new frmMovieInfo(movie);
            ia.Show();
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            var genre = (Genre)dgvGenres.CurrentRow.DataBoundItem;
            frmGenreInfo ia = new frmGenreInfo(genre);
            ia.Show();
        }

        /*
         * DELETE FUNCTIONS
         */
        private void btnDeleteActor_Click(object sender, EventArgs e)
        {
            var actor = (Actor)dgvActors.CurrentRow.DataBoundItem;
            if (confirm())
            {
                ac.deleteActor(actor);
                refresh(sender, e);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            var movie = (Movie)dgvMovies.CurrentRow.DataBoundItem;
            if (confirm())
            {
                mc.deleteMovie(movie);
                refresh(sender, e);
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            var genre = (Genre)dgvGenres.CurrentRow.DataBoundItem;
            if (confirm())
            {
                gc.deleteGenre(genre);
                refresh(sender, e);
            }
        }

        /*
         * DATAGRID CLICK DETAILS
         */
        private void dgvActors_Click(object sender, EventArgs e)
        {
            var actor = (Actor)dgvActors.CurrentRow.DataBoundItem;

            txtActorName.Text = actor.full_name;
            lbActorMovies.DataSource = actor.Movies.ToList();
            lbActorMovies.DisplayMember = "title";
        }

        private void dgvMovies_Click(object sender, EventArgs e)
        {
            var movie = (Movie)dgvMovies.CurrentRow.DataBoundItem;

            txtMovieName.Text = movie.title;
            lbMovieActors.DataSource = movie.Actors.ToList();
            lbMovieActors.DisplayMember = "full_name";
            lbMovieGenres.DataSource = movie.Genres.ToList();
            lbMovieGenres.DisplayMember = "name";
        }

        private void dgvGenres_Click(object sender, EventArgs e)
        {
            var genre = (Genre)dgvGenres.CurrentRow.DataBoundItem;

            txtGenreName.Text = genre.name;
            lbGenreMovies.DataSource = genre.Movies.ToList();
            lbGenreMovies.DisplayMember = "title";
        }

        private bool confirm()
        {
            if (MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
