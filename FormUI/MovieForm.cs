using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.IoC.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace FormUI
{
    public partial class MovieForm : Form
    {
        private IMovieService _movieService;
        private IGenreService _genreService;

        public MovieForm()
        {
            InitializeComponent();
            _movieService = InstanceFactory.GetInstance<IMovieService>();
            _genreService = InstanceFactory.GetInstance<IGenreService>();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadGenres();
        }

        private void LoadGenres()
        {
            cbxGenreId.DataSource = _genreService.GetAll();
            cbxGenreId.ValueMember = "Id";
            cbxGenreId.DisplayMember = "Name";
        }

        private void LoadMovies()
        {
            dgwMovies.DataSource = _movieService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _movieService.Add(new Movie
            {
                MovieId = this._movieService.GetNextId(),
                MovieName = tbxMovieNameAdd.Text,
                Imdb = Convert.ToDecimal(tbxImdbAdd.Text),
                GenreId = int.Parse(tbxGenreIdAdd.Text)
            });
            LoadMovies();
            MessageBox.Show("Added!", "System :");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _movieService.Update(new Movie
            {
                MovieId = (int)dgwMovies.CurrentRow.Cells[0].Value,
                MovieName = tbxMovieNameUpdate?.Text,
                Imdb = Convert.ToDecimal(tbxImdbUpdate.Text),
                GenreId = int.Parse(tbxGenreIdUpdate.Text)
            });
            LoadMovies();
            MessageBox.Show("Updated!", "System :");
        }

        private void dgwMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwMovies.CurrentRow.Cells;

            tbxMovieNameUpdate.Text = cells[1].Value.ToString();
            tbxImdbUpdate.Text = cells[2].Value.ToString();
            tbxGenreIdUpdate.Text = cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._movieService.Delete(new Movie
            {
                MovieId = (int)dgwMovies.CurrentRow.Cells[0].Value
            });
            LoadMovies();
            MessageBox.Show("Deleted!");
        }

        private void tbxIdSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwMovies.DataSource = this._movieService
                    .GetById(int.Parse(text));
            }
            else
            {
                LoadMovies();
            }
        }

        private void tbxMovieNameSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxMovieNameSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwMovies.DataSource = this._movieService.GetByMovieName(text);
            }
            else LoadMovies();
        }

        private void cbxGenreId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwMovies.DataSource = _movieService
                    .GetByGenreId((int)cbxGenreId.SelectedValue);
            }
            catch { }
        }

        private void tbxMin_TextChanged(object sender, EventArgs e)
        {
            LoadByImdb();
        }

        private void tbxMax_TextChanged(object sender, EventArgs e)
        {
            LoadByImdb();
        }

        private void LoadByImdb()
        {
            var minImdb = tbxMin.Text;
            decimal min = _movieService.GetMinImdb();
            decimal max = _movieService.GetMaxImdb();
            if (!String.IsNullOrEmpty(minImdb))
                min = Convert.ToDecimal(minImdb);
            
            var maxImdb = tbxMax.Text;
            if (!String.IsNullOrEmpty(maxImdb))
                max = Convert.ToDecimal(maxImdb);

            dgwMovies.DataSource = _movieService.GetByImdb(min, max);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void MovieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
