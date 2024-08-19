using System;
using System.Windows.Forms;

namespace testreport.Views
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMovieManagement movieManagement = new fMovieManagement();
            this.Hide();
            movieManagement.ShowDialog();
            this.Show();
        }
    }
}
