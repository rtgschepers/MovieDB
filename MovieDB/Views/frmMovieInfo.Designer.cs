namespace MovieDB
{
    partial class frmMovieInfo
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
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudRuntime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveActor = new System.Windows.Forms.Button();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.lbActors = new System.Windows.Forms.ListBox();
            this.bsActors = new System.Windows.Forms.BindingSource(this.components);
            this.lbMovieActors = new System.Windows.Forms.ListBox();
            this.bsMovieActors = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.bsGenres = new System.Windows.Forms.BindingSource(this.components);
            this.lbMovieGenres = new System.Windows.Forms.ListBox();
            this.bsMovieGenres = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovieActors)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovieGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(82, 21);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(200, 20);
            this.txbTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Runtime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Release date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rating";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(82, 99);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(200, 20);
            this.nudRating.TabIndex = 8;
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(82, 73);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReleaseDate.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudRuntime
            // 
            this.nudRuntime.Location = new System.Drawing.Point(82, 48);
            this.nudRuntime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRuntime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRuntime.Name = "nudRuntime";
            this.nudRuntime.Size = new System.Drawing.Size(200, 20);
            this.nudRuntime.TabIndex = 11;
            this.nudRuntime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudRuntime);
            this.groupBox1.Controls.Add(this.txbTitle);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpReleaseDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnRemoveActor);
            this.groupBox2.Controls.Add(this.btnAddActor);
            this.groupBox2.Controls.Add(this.lbActors);
            this.groupBox2.Controls.Add(this.lbMovieActors);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 222);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movie actors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "All actors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current actors";
            // 
            // btnRemoveActor
            // 
            this.btnRemoveActor.Location = new System.Drawing.Point(132, 115);
            this.btnRemoveActor.Name = "btnRemoveActor";
            this.btnRemoveActor.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveActor.TabIndex = 3;
            this.btnRemoveActor.Text = "=>";
            this.btnRemoveActor.UseVisualStyleBackColor = true;
            this.btnRemoveActor.Click += new System.EventHandler(this.btnRemoveActor_Click);
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(132, 86);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(29, 23);
            this.btnAddActor.TabIndex = 2;
            this.btnAddActor.Text = "<=";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // lbActors
            // 
            this.lbActors.DataSource = this.bsActors;
            this.lbActors.DisplayMember = "full_name";
            this.lbActors.FormattingEnabled = true;
            this.lbActors.Location = new System.Drawing.Point(168, 36);
            this.lbActors.Name = "lbActors";
            this.lbActors.Size = new System.Drawing.Size(120, 173);
            this.lbActors.TabIndex = 1;
            // 
            // lbMovieActors
            // 
            this.lbMovieActors.DataSource = this.bsMovieActors;
            this.lbMovieActors.DisplayMember = "full_name";
            this.lbMovieActors.FormattingEnabled = true;
            this.lbMovieActors.Location = new System.Drawing.Point(6, 36);
            this.lbMovieActors.Name = "lbMovieActors";
            this.lbMovieActors.Size = new System.Drawing.Size(120, 173);
            this.lbMovieActors.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnRemoveGenre);
            this.groupBox3.Controls.Add(this.btnAddGenre);
            this.groupBox3.Controls.Add(this.lbGenres);
            this.groupBox3.Controls.Add(this.lbMovieGenres);
            this.groupBox3.Location = new System.Drawing.Point(312, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 222);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie genres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "All genres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Current genres";
            // 
            // btnRemoveGenre
            // 
            this.btnRemoveGenre.Location = new System.Drawing.Point(132, 115);
            this.btnRemoveGenre.Name = "btnRemoveGenre";
            this.btnRemoveGenre.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveGenre.TabIndex = 3;
            this.btnRemoveGenre.Text = "=>";
            this.btnRemoveGenre.UseVisualStyleBackColor = true;
            this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(132, 86);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(29, 23);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "<=";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // lbGenres
            // 
            this.lbGenres.DataSource = this.bsGenres;
            this.lbGenres.DisplayMember = "name";
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(168, 36);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(120, 173);
            this.lbGenres.TabIndex = 1;
            // 
            // lbMovieGenres
            // 
            this.lbMovieGenres.DataSource = this.bsMovieGenres;
            this.lbMovieGenres.DisplayMember = "name";
            this.lbMovieGenres.FormattingEnabled = true;
            this.lbMovieGenres.Location = new System.Drawing.Point(6, 36);
            this.lbMovieGenres.Name = "lbMovieGenres";
            this.lbMovieGenres.Size = new System.Drawing.Size(120, 173);
            this.lbMovieGenres.TabIndex = 0;
            // 
            // frmMovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovieInfo";
            this.Text = "Movie Info";
            this.Load += new System.EventHandler(this.frmMovieInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovieActors)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovieGenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudRuntime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveActor;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.ListBox lbActors;
        private System.Windows.Forms.ListBox lbMovieActors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbMovieGenres;
        private System.Windows.Forms.BindingSource bsActors;
        private System.Windows.Forms.BindingSource bsGenres;
        private System.Windows.Forms.BindingSource bsMovieActors;
        private System.Windows.Forms.BindingSource bsMovieGenres;
    }
}