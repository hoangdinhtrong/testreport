using System;
using System.Windows.Forms;
using testreport.DAL.Repositories;
using testreport.Models.Dtos;
using testreport.Reports;

namespace testreport.Views
{
    public partial class fMovieManagement : Form
    {
        private BindingSource _movies = new BindingSource();
        public fMovieManagement()
        {
            InitializeComponent();
            dgvMovies.DataSource = _movies;
        }

        #region Methods

        private void SearchMovie()
        {
            MovieRequestDto request = new MovieRequestDto()
            {
                Title = txtTitle.Text,
                Genre = txtGenre.Text,
                Owner = txtOwner.Text,
                PageIndex = GetPageIndex(),
            };

            _movies.DataSource = MovieRepository.GetInstance().GetPaging(request);
        }

        private void LoadMovies()
        {
            
            _movies.DataSource = MovieRepository.GetInstance().GetPaging(new MovieRequestDto() { PageIndex = 0 });
        }

        private int GetPageIndex()
        {
            int page = Convert.ToInt32(txtCurrentPage.Text);
            if (page > 0)
                page--;
            else page = 0;

            return page;
        }

        private void ClearInput()
        {
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtOwner.Text = "";
        }
        #endregion

        #region Events
        private void btnView_Click(object sender, EventArgs e)
        {
            SearchMovie();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MovieCreateUpdateDto request = new MovieCreateUpdateDto()
                {
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    Owner = txtOwner.Text,
                };


                if (!MovieRepository.GetInstance().Insert(request))
                {
                    MessageBox.Show("Insert Faild!");
                    return;
                }

                LoadMovies();
                ClearInput();
                MessageBox.Show("Insert Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow != null && dgvMovies.CurrentRow.Index >= 0)
            {

                var row = dgvMovies.CurrentRow;
                txtTitle.Text = (row.Cells["Title"].Value != null) ? row.Cells["Title"].Value.ToString() : string.Empty;
                txtGenre.Text = (row.Cells["Genre"].Value != null) ? row.Cells["Genre"].Value.ToString() : string.Empty;
                txtOwner.Text = (row.Cells["Owner"].Value != null) ? row.Cells["Owner"].Value.ToString() : string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovies.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row!");
                    return;
                }

                MovieCreateUpdateDto request = new MovieCreateUpdateDto()
                {
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    Owner = txtOwner.Text,
                    Id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value),
                };


                if (!MovieRepository.GetInstance().Update(request))
                {
                    MessageBox.Show("Update Faild!");
                    return;
                }
                LoadMovies();
                ClearInput();

                MessageBox.Show("Update Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovies.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row!");
                    return;
                }

                if (!MovieRepository.GetInstance().Delete(Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value)))
                {
                    MessageBox.Show("Delete Faild!");
                    return;
                }
                LoadMovies();
                ClearInput();

                MessageBox.Show("Delete Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var movies = MovieRepository.GetInstance().GetMovies();

            MovieReport movieReport = new MovieReport();
            movieReport.SetDataSource(movies);

            fMovieReport fMovieReport = new fMovieReport();
            fMovieReport.movieCrystalReportViewer.ReportSource = movieReport;
            fMovieReport.ShowDialog();
        }
        #endregion
    }
}
