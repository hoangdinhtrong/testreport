namespace testreport.Views
{
    partial class fMovieReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movieCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // movieCrystalReportViewer
            // 
            this.movieCrystalReportViewer.ActiveViewIndex = -1;
            this.movieCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.movieCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.movieCrystalReportViewer.Name = "movieCrystalReportViewer";
            this.movieCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.movieCrystalReportViewer.TabIndex = 0;
            // 
            // fMovieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.movieCrystalReportViewer);
            this.Name = "fMovieReport";
            this.Text = "fMovieReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer movieCrystalReportViewer;
    }
}