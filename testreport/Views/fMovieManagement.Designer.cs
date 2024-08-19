namespace testreport.Views
{
    partial class fMovieManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPageLast = new System.Windows.Forms.Button();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.btnPageFirst = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lbOwner = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 121);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnView);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.btnEdit);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnReport);
            this.panel7.Location = new System.Drawing.Point(587, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(625, 54);
            this.panel7.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(29, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 40);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Search";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(267, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(505, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 40);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTitle);
            this.panel4.Controls.Add(this.lbTitle);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 47);
            this.panel4.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(54, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(277, 27);
            this.txtTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(7, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtGenre);
            this.panel6.Controls.Add(this.lbGenre);
            this.panel6.Location = new System.Drawing.Point(354, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 47);
            this.panel6.TabIndex = 0;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(68, 10);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(321, 27);
            this.txtGenre.TabIndex = 2;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(7, 17);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(55, 20);
            this.lbGenre.TabIndex = 0;
            this.lbGenre.Text = "Genre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMovies);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 519);
            this.panel2.TabIndex = 2;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(13, 15);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(1192, 424);
            this.dgvMovies.TabIndex = 1;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCurrentPage);
            this.panel3.Controls.Add(this.btnPageNext);
            this.panel3.Controls.Add(this.btnPageLast);
            this.panel3.Controls.Add(this.btnPagePrevious);
            this.panel3.Controls.Add(this.btnPageFirst);
            this.panel3.Location = new System.Drawing.Point(0, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 56);
            this.panel3.TabIndex = 0;
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPage.Location = new System.Drawing.Point(422, 12);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.ReadOnly = true;
            this.txtCurrentPage.Size = new System.Drawing.Size(341, 30);
            this.txtCurrentPage.TabIndex = 1;
            this.txtCurrentPage.TabStop = false;
            this.txtCurrentPage.Text = "1";
            this.txtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPageNext
            // 
            this.btnPageNext.Location = new System.Drawing.Point(973, 7);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(113, 40);
            this.btnPageNext.TabIndex = 11;
            this.btnPageNext.Text = "Next";
            this.btnPageNext.UseVisualStyleBackColor = true;
            // 
            // btnPageLast
            // 
            this.btnPageLast.Location = new System.Drawing.Point(1092, 7);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(113, 40);
            this.btnPageLast.TabIndex = 12;
            this.btnPageLast.Text = "Last";
            this.btnPageLast.UseVisualStyleBackColor = true;
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.Location = new System.Drawing.Point(128, 7);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(113, 40);
            this.btnPagePrevious.TabIndex = 10;
            this.btnPagePrevious.Text = "Previous";
            this.btnPagePrevious.UseVisualStyleBackColor = true;
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.Location = new System.Drawing.Point(9, 7);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(113, 40);
            this.btnPageFirst.TabIndex = 9;
            this.btnPageFirst.Text = "First";
            this.btnPageFirst.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtOwner);
            this.panel5.Controls.Add(this.lbOwner);
            this.panel5.Location = new System.Drawing.Point(752, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 47);
            this.panel5.TabIndex = 0;
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(71, 10);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(317, 27);
            this.txtOwner.TabIndex = 3;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwner.Location = new System.Drawing.Point(7, 17);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(58, 20);
            this.lbOwner.TabIndex = 0;
            this.lbOwner.Text = "Owner";
            // 
            // fMovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "fMovieManagement";
            this.Text = "fMovieManagement";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPageFirst;
        private System.Windows.Forms.TextBox txtCurrentPage;
        private System.Windows.Forms.Button btnPageNext;
        private System.Windows.Forms.Button btnPageLast;
        private System.Windows.Forms.Button btnPagePrevious;
    }
}