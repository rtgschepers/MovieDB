using System;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class frmGenreInfo : Form
    {
        private Genre genre;
        private GenreController gc;

        public frmGenreInfo()
        {
            InitializeComponent();
            this.genre = new Genre();
            gc = new GenreController();
        }

        public frmGenreInfo(Genre genre) : this()
        {
            this.genre = genre;
        }

        private void frmGenreInfo_Load(object sender, EventArgs e)
        {
            txbGenreName.DataBindings.Add("Text", genre, "name");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gc.saveGenre(genre);
            this.Close();
        }
    }
}
