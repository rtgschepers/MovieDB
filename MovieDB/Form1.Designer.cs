namespace MovieDB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.bsActors = new System.Windows.Forms.BindingSource(this.components);
            this.bsMovies = new System.Windows.Forms.BindingSource(this.components);
            this.bsGenres = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpActors = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbActorMovies = new System.Windows.Forms.ListBox();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteActor = new System.Windows.Forms.Button();
            this.btnUpdateActor = new System.Windows.Forms.Button();
            this.btnRefreshActors = new System.Windows.Forms.Button();
            this.btnCreateActor = new System.Windows.Forms.Button();
            this.tpMovies = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMovieActors = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMovieGenres = new System.Windows.Forms.ListBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnRefreshMovies = new System.Windows.Forms.Button();
            this.btnCreateMovie = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tpGenres = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbGenreMovies = new System.Windows.Forms.ListBox();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnRefreshGenre = new System.Windows.Forms.Button();
            this.btnCreateGenre = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpActors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpMovies.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tpGenres.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.DataSource = this.bsActors;
            this.dgvActors.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvActors.Location = new System.Drawing.Point(3, 3);
            this.dgvActors.MultiSelect = false;
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.ReadOnly = true;
            this.dgvActors.Size = new System.Drawing.Size(393, 455);
            this.dgvActors.TabIndex = 0;
            this.dgvActors.Click += new System.EventHandler(this.dgvActors_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpActors);
            this.tabControl1.Controls.Add(this.tpMovies);
            this.tabControl1.Controls.Add(this.tpGenres);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 487);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tpActors
            // 
            this.tpActors.Controls.Add(this.groupBox2);
            this.tpActors.Controls.Add(this.groupBox1);
            this.tpActors.Controls.Add(this.dgvActors);
            this.tpActors.Location = new System.Drawing.Point(4, 22);
            this.tpActors.Name = "tpActors";
            this.tpActors.Padding = new System.Windows.Forms.Padding(3);
            this.tpActors.Size = new System.Drawing.Size(602, 461);
            this.tpActors.TabIndex = 0;
            this.tpActors.Text = "Actors";
            this.tpActors.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbActorMovies);
            this.groupBox2.Controls.Add(this.txtActorName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(396, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 369);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movies the actor plays in";
            // 
            // lbActorMovies
            // 
            this.lbActorMovies.FormattingEnabled = true;
            this.lbActorMovies.Location = new System.Drawing.Point(6, 84);
            this.lbActorMovies.Name = "lbActorMovies";
            this.lbActorMovies.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbActorMovies.Size = new System.Drawing.Size(191, 121);
            this.lbActorMovies.TabIndex = 2;
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(6, 32);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.ReadOnly = true;
            this.txtActorName.Size = new System.Drawing.Size(191, 20);
            this.txtActorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the actor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteActor);
            this.groupBox1.Controls.Add(this.btnUpdateActor);
            this.groupBox1.Controls.Add(this.btnRefreshActors);
            this.groupBox1.Controls.Add(this.btnCreateActor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(396, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnDeleteActor
            // 
            this.btnDeleteActor.Location = new System.Drawing.Point(6, 50);
            this.btnDeleteActor.Name = "btnDeleteActor";
            this.btnDeleteActor.Size = new System.Drawing.Size(90, 25);
            this.btnDeleteActor.TabIndex = 3;
            this.btnDeleteActor.Text = "Delete Actor";
            this.btnDeleteActor.UseVisualStyleBackColor = true;
            this.btnDeleteActor.Click += new System.EventHandler(this.btnDeleteActor_Click);
            // 
            // btnUpdateActor
            // 
            this.btnUpdateActor.Location = new System.Drawing.Point(107, 19);
            this.btnUpdateActor.Name = "btnUpdateActor";
            this.btnUpdateActor.Size = new System.Drawing.Size(90, 25);
            this.btnUpdateActor.TabIndex = 2;
            this.btnUpdateActor.Text = "Update Actor";
            this.btnUpdateActor.UseVisualStyleBackColor = true;
            this.btnUpdateActor.Click += new System.EventHandler(this.btnUpdateActor_Click);
            // 
            // btnRefreshActors
            // 
            this.btnRefreshActors.Location = new System.Drawing.Point(107, 50);
            this.btnRefreshActors.Name = "btnRefreshActors";
            this.btnRefreshActors.Size = new System.Drawing.Size(90, 25);
            this.btnRefreshActors.TabIndex = 1;
            this.btnRefreshActors.Text = "Refresh";
            this.btnRefreshActors.UseVisualStyleBackColor = true;
            this.btnRefreshActors.Click += new System.EventHandler(this.refresh);
            // 
            // btnCreateActor
            // 
            this.btnCreateActor.Location = new System.Drawing.Point(6, 19);
            this.btnCreateActor.Name = "btnCreateActor";
            this.btnCreateActor.Size = new System.Drawing.Size(90, 25);
            this.btnCreateActor.TabIndex = 0;
            this.btnCreateActor.Text = "Create Actor";
            this.btnCreateActor.UseVisualStyleBackColor = true;
            this.btnCreateActor.Click += new System.EventHandler(this.btnCreateActor_Click);
            // 
            // tpMovies
            // 
            this.tpMovies.Controls.Add(this.groupBox3);
            this.tpMovies.Controls.Add(this.groupBox4);
            this.tpMovies.Controls.Add(this.dgvMovies);
            this.tpMovies.Location = new System.Drawing.Point(4, 22);
            this.tpMovies.Name = "tpMovies";
            this.tpMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovies.Size = new System.Drawing.Size(602, 461);
            this.tpMovies.TabIndex = 1;
            this.tpMovies.Text = "Movies";
            this.tpMovies.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbMovieActors);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbMovieGenres);
            this.groupBox3.Controls.Add(this.txtMovieName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(396, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 369);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // lbMovieActors
            // 
            this.lbMovieActors.FormattingEnabled = true;
            this.lbMovieActors.Location = new System.Drawing.Point(6, 234);
            this.lbMovieActors.Name = "lbMovieActors";
            this.lbMovieActors.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbMovieActors.Size = new System.Drawing.Size(191, 121);
            this.lbMovieActors.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actors that play in this movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "This movies\' genres";
            // 
            // lbMovieGenres
            // 
            this.lbMovieGenres.FormattingEnabled = true;
            this.lbMovieGenres.Location = new System.Drawing.Point(6, 84);
            this.lbMovieGenres.Name = "lbMovieGenres";
            this.lbMovieGenres.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbMovieGenres.Size = new System.Drawing.Size(191, 121);
            this.lbMovieGenres.TabIndex = 2;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(6, 32);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.ReadOnly = true;
            this.txtMovieName.Size = new System.Drawing.Size(191, 20);
            this.txtMovieName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name of the movie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteMovie);
            this.groupBox4.Controls.Add(this.btnUpdateMovie);
            this.groupBox4.Controls.Add(this.btnRefreshMovies);
            this.groupBox4.Controls.Add(this.btnCreateMovie);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(396, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 86);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(6, 50);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(90, 25);
            this.btnDeleteMovie.TabIndex = 3;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(107, 19);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(90, 25);
            this.btnUpdateMovie.TabIndex = 2;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnRefreshMovies
            // 
            this.btnRefreshMovies.Location = new System.Drawing.Point(107, 50);
            this.btnRefreshMovies.Name = "btnRefreshMovies";
            this.btnRefreshMovies.Size = new System.Drawing.Size(90, 25);
            this.btnRefreshMovies.TabIndex = 1;
            this.btnRefreshMovies.Text = "Refresh";
            this.btnRefreshMovies.UseVisualStyleBackColor = true;
            this.btnRefreshMovies.Click += new System.EventHandler(this.refresh);
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(6, 19);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(90, 25);
            this.btnCreateMovie.TabIndex = 0;
            this.btnCreateMovie.Text = "Create Movie";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AutoGenerateColumns = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.DataSource = this.bsMovies;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.Size = new System.Drawing.Size(393, 455);
            this.dgvMovies.TabIndex = 3;
            this.dgvMovies.Click += new System.EventHandler(this.dgvMovies_Click);
            // 
            // tpGenres
            // 
            this.tpGenres.Controls.Add(this.groupBox5);
            this.tpGenres.Controls.Add(this.groupBox6);
            this.tpGenres.Controls.Add(this.dgvGenres);
            this.tpGenres.Location = new System.Drawing.Point(4, 22);
            this.tpGenres.Name = "tpGenres";
            this.tpGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenres.Size = new System.Drawing.Size(602, 461);
            this.tpGenres.TabIndex = 2;
            this.tpGenres.Text = "Genres";
            this.tpGenres.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lbGenreMovies);
            this.groupBox5.Controls.Add(this.txtGenreName);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(396, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 369);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Movies that have this genre";
            // 
            // lbGenreMovies
            // 
            this.lbGenreMovies.FormattingEnabled = true;
            this.lbGenreMovies.Location = new System.Drawing.Point(6, 84);
            this.lbGenreMovies.Name = "lbGenreMovies";
            this.lbGenreMovies.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbGenreMovies.Size = new System.Drawing.Size(191, 121);
            this.lbGenreMovies.TabIndex = 2;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(6, 32);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.ReadOnly = true;
            this.txtGenreName.Size = new System.Drawing.Size(191, 20);
            this.txtGenreName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name of the genre";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteGenre);
            this.groupBox6.Controls.Add(this.btnUpdateGenre);
            this.groupBox6.Controls.Add(this.btnRefreshGenre);
            this.groupBox6.Controls.Add(this.btnCreateGenre);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(396, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(203, 86);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controls";
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(6, 50);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(90, 25);
            this.btnDeleteGenre.TabIndex = 3;
            this.btnDeleteGenre.Text = "Delete Genre";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(107, 19);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(90, 25);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Update Genre";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnRefreshGenre
            // 
            this.btnRefreshGenre.Location = new System.Drawing.Point(107, 50);
            this.btnRefreshGenre.Name = "btnRefreshGenre";
            this.btnRefreshGenre.Size = new System.Drawing.Size(90, 25);
            this.btnRefreshGenre.TabIndex = 1;
            this.btnRefreshGenre.Text = "Refresh";
            this.btnRefreshGenre.UseVisualStyleBackColor = true;
            this.btnRefreshGenre.Click += new System.EventHandler(this.refresh);
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(6, 19);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(90, 25);
            this.btnCreateGenre.TabIndex = 0;
            this.btnCreateGenre.Text = "Create Genre";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.btnCreateGenre_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AutoGenerateColumns = false;
            this.dgvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.DataSource = this.bsGenres;
            this.dgvGenres.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGenres.Location = new System.Drawing.Point(3, 3);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            this.dgvGenres.Size = new System.Drawing.Size(393, 455);
            this.dgvGenres.TabIndex = 3;
            this.dgvGenres.Click += new System.EventHandler(this.dgvGenres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpActors.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tpMovies.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tpGenres.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.BindingSource bsActors;
        private System.Windows.Forms.BindingSource bsMovies;
        private System.Windows.Forms.BindingSource bsGenres;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpActors;
        private System.Windows.Forms.TabPage tpMovies;
        private System.Windows.Forms.TabPage tpGenres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateActor;
        private System.Windows.Forms.Button btnRefreshActors;
        private System.Windows.Forms.Button btnDeleteActor;
        private System.Windows.Forms.Button btnUpdateActor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbActorMovies;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMovieGenres;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnRefreshMovies;
        private System.Windows.Forms.Button btnCreateMovie;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.ListBox lbMovieActors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbGenreMovies;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnRefreshGenre;
        private System.Windows.Forms.Button btnCreateGenre;
        private System.Windows.Forms.DataGridView dgvGenres;
    }
}

