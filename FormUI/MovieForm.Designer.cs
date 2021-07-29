
namespace FormUI
{
    partial class MovieForm
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
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxGenreIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxImdbUpdate = new System.Windows.Forms.TextBox();
            this.tbxMovieNameUpdate = new System.Windows.Forms.TextBox();
            this.lblGenreIdUpdate = new System.Windows.Forms.Label();
            this.lblImdbUpdate = new System.Windows.Forms.Label();
            this.lblMovieNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxGenreIdAdd = new System.Windows.Forms.TextBox();
            this.tbxImdbAdd = new System.Windows.Forms.TextBox();
            this.tbxMovieNameAdd = new System.Windows.Forms.TextBox();
            this.lblGenreIdAdd = new System.Windows.Forms.Label();
            this.lblImdbAdd = new System.Windows.Forms.Label();
            this.lblMovieNameAdd = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.lblImdb = new System.Windows.Forms.Label();
            this.cbxGenreId = new System.Windows.Forms.ComboBox();
            this.tbxMovieNameSearch = new System.Windows.Forms.TextBox();
            this.tbxIdSearch = new System.Windows.Forms.TextBox();
            this.lblMovieNameSearch = new System.Windows.Forms.Label();
            this.lblGenreIdSearch = new System.Windows.Forms.Label();
            this.lblIdSearch = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMovies
            // 
            this.dgwMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovies.Location = new System.Drawing.Point(33, 68);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.RowHeadersWidth = 51;
            this.dgwMovies.RowTemplate.Height = 24;
            this.dgwMovies.Size = new System.Drawing.Size(1081, 271);
            this.dgwMovies.TabIndex = 0;
            this.dgwMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMovies_CellClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(33, 371);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(590, 312);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 37);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxGenreIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxImdbUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMovieNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblGenreIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblImdbUpdate);
            this.gbxUpdate.Controls.Add(this.lblMovieNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(317, 45);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(253, 218);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxGenreIdUpdate
            // 
            this.tbxGenreIdUpdate.Location = new System.Drawing.Point(147, 124);
            this.tbxGenreIdUpdate.Name = "tbxGenreIdUpdate";
            this.tbxGenreIdUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxGenreIdUpdate.TabIndex = 11;
            // 
            // tbxImdbUpdate
            // 
            this.tbxImdbUpdate.Location = new System.Drawing.Point(147, 83);
            this.tbxImdbUpdate.Name = "tbxImdbUpdate";
            this.tbxImdbUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxImdbUpdate.TabIndex = 10;
            // 
            // tbxMovieNameUpdate
            // 
            this.tbxMovieNameUpdate.Location = new System.Drawing.Point(147, 42);
            this.tbxMovieNameUpdate.Name = "tbxMovieNameUpdate";
            this.tbxMovieNameUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxMovieNameUpdate.TabIndex = 9;
            // 
            // lblGenreIdUpdate
            // 
            this.lblGenreIdUpdate.AutoSize = true;
            this.lblGenreIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenreIdUpdate.Location = new System.Drawing.Point(26, 131);
            this.lblGenreIdUpdate.Name = "lblGenreIdUpdate";
            this.lblGenreIdUpdate.Size = new System.Drawing.Size(73, 20);
            this.lblGenreIdUpdate.TabIndex = 8;
            this.lblGenreIdUpdate.Text = "Genre Id";
            // 
            // lblImdbUpdate
            // 
            this.lblImdbUpdate.AutoSize = true;
            this.lblImdbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImdbUpdate.Location = new System.Drawing.Point(26, 90);
            this.lblImdbUpdate.Name = "lblImdbUpdate";
            this.lblImdbUpdate.Size = new System.Drawing.Size(45, 20);
            this.lblImdbUpdate.TabIndex = 7;
            this.lblImdbUpdate.Text = "Imdb";
            // 
            // lblMovieNameUpdate
            // 
            this.lblMovieNameUpdate.AutoSize = true;
            this.lblMovieNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovieNameUpdate.Location = new System.Drawing.Point(26, 49);
            this.lblMovieNameUpdate.Name = "lblMovieNameUpdate";
            this.lblMovieNameUpdate.Size = new System.Drawing.Size(102, 20);
            this.lblMovieNameUpdate.TabIndex = 6;
            this.lblMovieNameUpdate.Text = "Movie Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxGenreIdAdd);
            this.gbxAdd.Controls.Add(this.tbxImdbAdd);
            this.gbxAdd.Controls.Add(this.tbxMovieNameAdd);
            this.gbxAdd.Controls.Add(this.lblGenreIdAdd);
            this.gbxAdd.Controls.Add(this.lblImdbAdd);
            this.gbxAdd.Controls.Add(this.lblMovieNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(18, 45);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(253, 218);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxGenreIdAdd
            // 
            this.tbxGenreIdAdd.Location = new System.Drawing.Point(147, 124);
            this.tbxGenreIdAdd.Name = "tbxGenreIdAdd";
            this.tbxGenreIdAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxGenreIdAdd.TabIndex = 5;
            // 
            // tbxImdbAdd
            // 
            this.tbxImdbAdd.Location = new System.Drawing.Point(147, 83);
            this.tbxImdbAdd.Name = "tbxImdbAdd";
            this.tbxImdbAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxImdbAdd.TabIndex = 4;
            // 
            // tbxMovieNameAdd
            // 
            this.tbxMovieNameAdd.Location = new System.Drawing.Point(147, 42);
            this.tbxMovieNameAdd.Name = "tbxMovieNameAdd";
            this.tbxMovieNameAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxMovieNameAdd.TabIndex = 3;
            // 
            // lblGenreIdAdd
            // 
            this.lblGenreIdAdd.AutoSize = true;
            this.lblGenreIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenreIdAdd.Location = new System.Drawing.Point(23, 126);
            this.lblGenreIdAdd.Name = "lblGenreIdAdd";
            this.lblGenreIdAdd.Size = new System.Drawing.Size(73, 20);
            this.lblGenreIdAdd.TabIndex = 2;
            this.lblGenreIdAdd.Text = "Genre Id";
            // 
            // lblImdbAdd
            // 
            this.lblImdbAdd.AutoSize = true;
            this.lblImdbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImdbAdd.Location = new System.Drawing.Point(23, 85);
            this.lblImdbAdd.Name = "lblImdbAdd";
            this.lblImdbAdd.Size = new System.Drawing.Size(45, 20);
            this.lblImdbAdd.TabIndex = 1;
            this.lblImdbAdd.Text = "Imdb";
            // 
            // lblMovieNameAdd
            // 
            this.lblMovieNameAdd.AutoSize = true;
            this.lblMovieNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovieNameAdd.Location = new System.Drawing.Point(23, 44);
            this.lblMovieNameAdd.Name = "lblMovieNameAdd";
            this.lblMovieNameAdd.Size = new System.Drawing.Size(102, 20);
            this.lblMovieNameAdd.TabIndex = 0;
            this.lblMovieNameAdd.Text = "Movie Name";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblMax);
            this.gbxSearch.Controls.Add(this.lblMin);
            this.gbxSearch.Controls.Add(this.tbxMax);
            this.gbxSearch.Controls.Add(this.tbxMin);
            this.gbxSearch.Controls.Add(this.lblImdb);
            this.gbxSearch.Controls.Add(this.cbxGenreId);
            this.gbxSearch.Controls.Add(this.tbxMovieNameSearch);
            this.gbxSearch.Controls.Add(this.tbxIdSearch);
            this.gbxSearch.Controls.Add(this.lblMovieNameSearch);
            this.gbxSearch.Controls.Add(this.lblGenreIdSearch);
            this.gbxSearch.Controls.Add(this.lblIdSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearch.Location = new System.Drawing.Point(654, 371);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(460, 312);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMax.Location = new System.Drawing.Point(117, 235);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(50, 25);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMin.Location = new System.Drawing.Point(117, 193);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(44, 25);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Min";
            // 
            // tbxMax
            // 
            this.tbxMax.Location = new System.Drawing.Point(189, 229);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(48, 34);
            this.tbxMax.TabIndex = 8;
            this.tbxMax.TextChanged += new System.EventHandler(this.tbxMax_TextChanged);
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(189, 187);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(48, 34);
            this.tbxMin.TabIndex = 7;
            this.tbxMin.TextChanged += new System.EventHandler(this.tbxMin_TextChanged);
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImdb.Location = new System.Drawing.Point(39, 213);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(66, 25);
            this.lblImdb.TabIndex = 6;
            this.lblImdb.Text = "Imdb :";
            // 
            // cbxGenreId
            // 
            this.cbxGenreId.FormattingEnabled = true;
            this.cbxGenreId.Location = new System.Drawing.Point(202, 126);
            this.cbxGenreId.Name = "cbxGenreId";
            this.cbxGenreId.Size = new System.Drawing.Size(100, 37);
            this.cbxGenreId.TabIndex = 5;
            this.cbxGenreId.SelectedIndexChanged += new System.EventHandler(this.cbxGenreId_SelectedIndexChanged);
            // 
            // tbxMovieNameSearch
            // 
            this.tbxMovieNameSearch.Location = new System.Drawing.Point(202, 84);
            this.tbxMovieNameSearch.Name = "tbxMovieNameSearch";
            this.tbxMovieNameSearch.Size = new System.Drawing.Size(100, 34);
            this.tbxMovieNameSearch.TabIndex = 4;
            this.tbxMovieNameSearch.TextChanged += new System.EventHandler(this.tbxMovieNameSearch_TextChanged);
            // 
            // tbxIdSearch
            // 
            this.tbxIdSearch.Location = new System.Drawing.Point(202, 38);
            this.tbxIdSearch.Name = "tbxIdSearch";
            this.tbxIdSearch.Size = new System.Drawing.Size(100, 34);
            this.tbxIdSearch.TabIndex = 3;
            this.tbxIdSearch.TextChanged += new System.EventHandler(this.tbxIdSearch_TextChanged);
            // 
            // lblMovieNameSearch
            // 
            this.lblMovieNameSearch.AutoSize = true;
            this.lblMovieNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovieNameSearch.Location = new System.Drawing.Point(39, 88);
            this.lblMovieNameSearch.Name = "lblMovieNameSearch";
            this.lblMovieNameSearch.Size = new System.Drawing.Size(119, 25);
            this.lblMovieNameSearch.TabIndex = 2;
            this.lblMovieNameSearch.Text = "Movie name";
            // 
            // lblGenreIdSearch
            // 
            this.lblGenreIdSearch.AutoSize = true;
            this.lblGenreIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenreIdSearch.Location = new System.Drawing.Point(39, 132);
            this.lblGenreIdSearch.Name = "lblGenreIdSearch";
            this.lblGenreIdSearch.Size = new System.Drawing.Size(86, 25);
            this.lblGenreIdSearch.TabIndex = 1;
            this.lblGenreIdSearch.Text = "Genre id";
            // 
            // lblIdSearch
            // 
            this.lblIdSearch.AutoSize = true;
            this.lblIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdSearch.Location = new System.Drawing.Point(39, 44);
            this.lblIdSearch.Name = "lblIdSearch";
            this.lblIdSearch.Size = new System.Drawing.Size(28, 25);
            this.lblIdSearch.TabIndex = 0;
            this.lblIdSearch.Text = "Id";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(10, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(109, 46);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 708);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwMovies);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieForm_FormClosing);
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblGenreIdAdd;
        private System.Windows.Forms.Label lblImdbAdd;
        private System.Windows.Forms.Label lblMovieNameAdd;
        private System.Windows.Forms.TextBox tbxGenreIdAdd;
        private System.Windows.Forms.TextBox tbxImdbAdd;
        private System.Windows.Forms.TextBox tbxMovieNameAdd;
        private System.Windows.Forms.TextBox tbxGenreIdUpdate;
        private System.Windows.Forms.TextBox tbxImdbUpdate;
        private System.Windows.Forms.TextBox tbxMovieNameUpdate;
        private System.Windows.Forms.Label lblGenreIdUpdate;
        private System.Windows.Forms.Label lblImdbUpdate;
        private System.Windows.Forms.Label lblMovieNameUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxMovieNameSearch;
        private System.Windows.Forms.TextBox tbxIdSearch;
        private System.Windows.Forms.Label lblMovieNameSearch;
        private System.Windows.Forms.Label lblGenreIdSearch;
        private System.Windows.Forms.Label lblIdSearch;
        private System.Windows.Forms.ComboBox cbxGenreId;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Button btnMenu;
    }
}

