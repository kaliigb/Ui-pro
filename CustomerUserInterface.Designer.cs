namespace Cinema
{
    partial class CustomerUserInterface
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.btn_Lte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_filterByAge = new System.Windows.Forms.TextBox();
            this.btn_Gte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filterByCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_filterByName = new System.Windows.Forms.TextBox();
            this.btn_filterByName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshMovieList = new System.Windows.Forms.Button();
            this.checkBox_3d = new System.Windows.Forms.CheckBox();
            this.checkBox_4dx = new System.Windows.Forms.CheckBox();
            this.checkBox_2d = new System.Windows.Forms.CheckBox();
            this.dataGridView_moviesList = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Category);
            this.groupBox2.Controls.Add(this.btn_Lte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBox_filterByAge);
            this.groupBox2.Controls.Add(this.btn_Gte);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_filterByCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBox_filterByName);
            this.groupBox2.Controls.Add(this.btn_filterByName);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By :";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.comboBox_Category.Location = new System.Drawing.Point(196, 80);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(292, 24);
            this.comboBox_Category.TabIndex = 14;
            // 
            // btn_Lte
            // 
            this.btn_Lte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lte.ForeColor = System.Drawing.Color.Red;
            this.btn_Lte.Location = new System.Drawing.Point(677, 125);
            this.btn_Lte.Name = "btn_Lte";
            this.btn_Lte.Size = new System.Drawing.Size(137, 29);
            this.btn_Lte.TabIndex = 13;
            this.btn_Lte.Text = "Lower than";
            this.btn_Lte.UseVisualStyleBackColor = true;
            this.btn_Lte.Click += new System.EventHandler(this.btn_Lte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter By Age : ";
            // 
            // txtBox_filterByAge
            // 
            this.txtBox_filterByAge.Location = new System.Drawing.Point(196, 126);
            this.txtBox_filterByAge.Name = "txtBox_filterByAge";
            this.txtBox_filterByAge.Size = new System.Drawing.Size(292, 22);
            this.txtBox_filterByAge.TabIndex = 11;
            // 
            // btn_Gte
            // 
            this.btn_Gte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gte.ForeColor = System.Drawing.Color.Red;
            this.btn_Gte.Location = new System.Drawing.Point(521, 126);
            this.btn_Gte.Name = "btn_Gte";
            this.btn_Gte.Size = new System.Drawing.Size(137, 29);
            this.btn_Gte.TabIndex = 10;
            this.btn_Gte.Text = "Greater than";
            this.btn_Gte.UseVisualStyleBackColor = true;
            this.btn_Gte.Click += new System.EventHandler(this.btn_Gte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter By Category : ";
            // 
            // btn_filterByCategory
            // 
            this.btn_filterByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterByCategory.ForeColor = System.Drawing.Color.Red;
            this.btn_filterByCategory.Location = new System.Drawing.Point(521, 78);
            this.btn_filterByCategory.Name = "btn_filterByCategory";
            this.btn_filterByCategory.Size = new System.Drawing.Size(293, 29);
            this.btn_filterByCategory.TabIndex = 7;
            this.btn_filterByCategory.Text = "Filter By Category";
            this.btn_filterByCategory.UseVisualStyleBackColor = true;
            this.btn_filterByCategory.Click += new System.EventHandler(this.btn_filterByCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By Name : ";
            // 
            // txtBox_filterByName
            // 
            this.txtBox_filterByName.Location = new System.Drawing.Point(196, 33);
            this.txtBox_filterByName.Name = "txtBox_filterByName";
            this.txtBox_filterByName.Size = new System.Drawing.Size(292, 22);
            this.txtBox_filterByName.TabIndex = 5;
            // 
            // btn_filterByName
            // 
            this.btn_filterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterByName.ForeColor = System.Drawing.Color.Red;
            this.btn_filterByName.Location = new System.Drawing.Point(521, 33);
            this.btn_filterByName.Name = "btn_filterByName";
            this.btn_filterByName.Size = new System.Drawing.Size(293, 29);
            this.btn_filterByName.TabIndex = 4;
            this.btn_filterByName.Text = "Search By Name ";
            this.btn_filterByName.UseVisualStyleBackColor = true;
            this.btn_filterByName.Click += new System.EventHandler(this.btn_filterByName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RefreshMovieList);
            this.groupBox1.Controls.Add(this.checkBox_3d);
            this.groupBox1.Controls.Add(this.checkBox_4dx);
            this.groupBox1.Controls.Add(this.checkBox_2d);
            this.groupBox1.Controls.Add(this.dataGridView_moviesList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie List :";
            // 
            // btn_RefreshMovieList
            // 
            this.btn_RefreshMovieList.BackColor = System.Drawing.Color.White;
            this.btn_RefreshMovieList.ForeColor = System.Drawing.Color.Red;
            this.btn_RefreshMovieList.Location = new System.Drawing.Point(190, 202);
            this.btn_RefreshMovieList.Name = "btn_RefreshMovieList";
            this.btn_RefreshMovieList.Size = new System.Drawing.Size(299, 38);
            this.btn_RefreshMovieList.TabIndex = 4;
            this.btn_RefreshMovieList.Text = "Refresh Movie List";
            this.btn_RefreshMovieList.UseVisualStyleBackColor = false;
            this.btn_RefreshMovieList.Click += new System.EventHandler(this.btn_RefreshMovieList_Click);
            // 
            // checkBox_3d
            // 
            this.checkBox_3d.AutoSize = true;
            this.checkBox_3d.ForeColor = System.Drawing.Color.White;
            this.checkBox_3d.Location = new System.Drawing.Point(616, 211);
            this.checkBox_3d.Name = "checkBox_3d";
            this.checkBox_3d.Size = new System.Drawing.Size(51, 22);
            this.checkBox_3d.TabIndex = 3;
            this.checkBox_3d.Text = "3D";
            this.checkBox_3d.UseVisualStyleBackColor = true;
            this.checkBox_3d.CheckedChanged += new System.EventHandler(this.checkBox_3d_CheckedChanged);
            // 
            // checkBox_4dx
            // 
            this.checkBox_4dx.AutoSize = true;
            this.checkBox_4dx.ForeColor = System.Drawing.Color.White;
            this.checkBox_4dx.Location = new System.Drawing.Point(695, 211);
            this.checkBox_4dx.Name = "checkBox_4dx";
            this.checkBox_4dx.Size = new System.Drawing.Size(62, 22);
            this.checkBox_4dx.TabIndex = 2;
            this.checkBox_4dx.Text = "4DX";
            this.checkBox_4dx.UseVisualStyleBackColor = true;
            this.checkBox_4dx.CheckedChanged += new System.EventHandler(this.checkBox_4dx_CheckedChanged);
            // 
            // checkBox_2d
            // 
            this.checkBox_2d.AutoSize = true;
            this.checkBox_2d.ForeColor = System.Drawing.Color.White;
            this.checkBox_2d.Location = new System.Drawing.Point(532, 211);
            this.checkBox_2d.Name = "checkBox_2d";
            this.checkBox_2d.Size = new System.Drawing.Size(51, 22);
            this.checkBox_2d.TabIndex = 1;
            this.checkBox_2d.Text = "2D";
            this.checkBox_2d.UseVisualStyleBackColor = true;
            this.checkBox_2d.CheckedChanged += new System.EventHandler(this.checkBox_2d_CheckedChanged);
            // 
            // dataGridView_moviesList
            // 
            this.dataGridView_moviesList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_moviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_moviesList.Location = new System.Drawing.Point(27, 32);
            this.dataGridView_moviesList.Name = "dataGridView_moviesList";
            this.dataGridView_moviesList.RowHeadersWidth = 62;
            this.dataGridView_moviesList.RowTemplate.Height = 29;
            this.dataGridView_moviesList.Size = new System.Drawing.Size(787, 163);
            this.dataGridView_moviesList.TabIndex = 0;
            this.dataGridView_moviesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_moviesList_CellDoubleClick);
            // 
            // CustomerUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(853, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerUserInterface";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CustomerUserInterface_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moviesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_3d;
        private System.Windows.Forms.CheckBox checkBox_4dx;
        private System.Windows.Forms.CheckBox checkBox_2d;
        private System.Windows.Forms.DataGridView dataGridView_moviesList;
        private System.Windows.Forms.Button btn_RefreshMovieList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_filterByAge;
        private System.Windows.Forms.Button btn_Gte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filterByCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_filterByName;
        private System.Windows.Forms.Button btn_filterByName;
        private System.Windows.Forms.Button btn_Lte;
        private System.Windows.Forms.ComboBox comboBox_Category;
    }
}