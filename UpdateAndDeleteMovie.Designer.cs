namespace Cinema
{
    partial class UpdateAndDeleteMovie
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
            this.txtBox_Trailer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBox_age = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Projection = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.btn_uploadMovie = new System.Windows.Forms.Button();
            this.txtBox_posterPath = new System.Windows.Forms.TextBox();
            this.txtBox_Director = new System.Windows.Forms.TextBox();
            this.txtBox_Duration = new System.Windows.Forms.TextBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_MovieName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            this.txtBox_Categories = new System.Windows.Forms.TextBox();
            this.btn_removeTime = new System.Windows.Forms.Button();
            this.txtBox_Hour = new System.Windows.Forms.TextBox();
            this.btn_addTime = new System.Windows.Forms.Button();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Dates = new System.Windows.Forms.ComboBox();
            this.btn_removeDate = new System.Windows.Forms.Button();
            this.btn_addDate = new System.Windows.Forms.Button();
            this.txtBox_Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_Trailer
            // 
            this.txtBox_Trailer.Location = new System.Drawing.Point(341, 123);
            this.txtBox_Trailer.Name = "txtBox_Trailer";
            this.txtBox_Trailer.Size = new System.Drawing.Size(198, 22);
            this.txtBox_Trailer.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(250, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Trailer :";
            // 
            // txtBox_age
            // 
            this.txtBox_age.Location = new System.Drawing.Point(341, 263);
            this.txtBox_age.Name = "txtBox_age";
            this.txtBox_age.Size = new System.Drawing.Size(78, 22);
            this.txtBox_age.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(257, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "Age :";
            // 
            // comboBox_Projection
            // 
            this.comboBox_Projection.FormattingEnabled = true;
            this.comboBox_Projection.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4DX"});
            this.comboBox_Projection.Location = new System.Drawing.Point(108, 165);
            this.comboBox_Projection.Name = "comboBox_Projection";
            this.comboBox_Projection.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Projection.TabIndex = 49;
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
            this.comboBox_Category.Location = new System.Drawing.Point(470, 36);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(71, 24);
            this.comboBox_Category.TabIndex = 48;
            // 
            // btn_uploadMovie
            // 
            this.btn_uploadMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uploadMovie.ForeColor = System.Drawing.Color.Red;
            this.btn_uploadMovie.Location = new System.Drawing.Point(563, 78);
            this.btn_uploadMovie.Name = "btn_uploadMovie";
            this.btn_uploadMovie.Size = new System.Drawing.Size(78, 35);
            this.btn_uploadMovie.TabIndex = 46;
            this.btn_uploadMovie.Text = "Upload";
            this.btn_uploadMovie.UseVisualStyleBackColor = true;
            this.btn_uploadMovie.Click += new System.EventHandler(this.btn_uploadMovie_Click);
            // 
            // txtBox_posterPath
            // 
            this.txtBox_posterPath.Location = new System.Drawing.Point(341, 79);
            this.txtBox_posterPath.Name = "txtBox_posterPath";
            this.txtBox_posterPath.Size = new System.Drawing.Size(198, 22);
            this.txtBox_posterPath.TabIndex = 45;
            // 
            // txtBox_Director
            // 
            this.txtBox_Director.Location = new System.Drawing.Point(108, 120);
            this.txtBox_Director.Name = "txtBox_Director";
            this.txtBox_Director.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Director.TabIndex = 44;
            // 
            // txtBox_Duration
            // 
            this.txtBox_Duration.Location = new System.Drawing.Point(108, 261);
            this.txtBox_Duration.Name = "txtBox_Duration";
            this.txtBox_Duration.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Duration.TabIndex = 43;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(108, 213);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Price.TabIndex = 42;
            // 
            // txtBox_MovieName
            // 
            this.txtBox_MovieName.Location = new System.Drawing.Point(108, 81);
            this.txtBox_MovieName.Name = "txtBox_MovieName";
            this.txtBox_MovieName.Size = new System.Drawing.Size(121, 22);
            this.txtBox_MovieName.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(249, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Poster :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Director :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Duration :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Projection :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(249, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Name :";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(401, 321);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(164, 63);
            this.btn_delete.TabIndex = 58;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Red;
            this.btn_update.Location = new System.Drawing.Point(96, 321);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(171, 63);
            this.btn_update.TabIndex = 57;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.ForeColor = System.Drawing.Color.Red;
            this.btn_addCategory.Location = new System.Drawing.Point(547, 31);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(57, 36);
            this.btn_addCategory.TabIndex = 59;
            this.btn_addCategory.Text = "add";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeCategory.ForeColor = System.Drawing.Color.Red;
            this.btn_removeCategory.Location = new System.Drawing.Point(610, 31);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(81, 37);
            this.btn_removeCategory.TabIndex = 60;
            this.btn_removeCategory.Text = "remove";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // txtBox_Categories
            // 
            this.txtBox_Categories.Location = new System.Drawing.Point(341, 38);
            this.txtBox_Categories.Name = "txtBox_Categories";
            this.txtBox_Categories.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Categories.TabIndex = 61;
            // 
            // btn_removeTime
            // 
            this.btn_removeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeTime.ForeColor = System.Drawing.Color.Red;
            this.btn_removeTime.Location = new System.Drawing.Point(610, 207);
            this.btn_removeTime.Name = "btn_removeTime";
            this.btn_removeTime.Size = new System.Drawing.Size(81, 37);
            this.btn_removeTime.TabIndex = 68;
            this.btn_removeTime.Text = "remove";
            this.btn_removeTime.UseVisualStyleBackColor = true;
            this.btn_removeTime.Click += new System.EventHandler(this.btn_removeTime_Click);
            // 
            // txtBox_Hour
            // 
            this.txtBox_Hour.Location = new System.Drawing.Point(453, 209);
            this.txtBox_Hour.Name = "txtBox_Hour";
            this.txtBox_Hour.Size = new System.Drawing.Size(83, 22);
            this.txtBox_Hour.TabIndex = 67;
            // 
            // btn_addTime
            // 
            this.btn_addTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTime.ForeColor = System.Drawing.Color.Red;
            this.btn_addTime.Location = new System.Drawing.Point(547, 208);
            this.btn_addTime.Name = "btn_addTime";
            this.btn_addTime.Size = new System.Drawing.Size(57, 36);
            this.btn_addTime.TabIndex = 66;
            this.btn_addTime.Text = "add";
            this.btn_addTime.UseVisualStyleBackColor = true;
            this.btn_addTime.Click += new System.EventHandler(this.btn_addTime_Click);
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.Location = new System.Drawing.Point(341, 209);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(106, 24);
            this.comboBox_Hours.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(250, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "Time :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(250, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Date :";
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(108, 36);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.ReadOnly = true;
            this.txtBox_Id.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Id.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Object Id :";
            // 
            // comboBox_Dates
            // 
            this.comboBox_Dates.FormattingEnabled = true;
            this.comboBox_Dates.Location = new System.Drawing.Point(341, 165);
            this.comboBox_Dates.Name = "comboBox_Dates";
            this.comboBox_Dates.Size = new System.Drawing.Size(106, 24);
            this.comboBox_Dates.TabIndex = 71;
            // 
            // btn_removeDate
            // 
            this.btn_removeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeDate.ForeColor = System.Drawing.Color.Red;
            this.btn_removeDate.Location = new System.Drawing.Point(610, 158);
            this.btn_removeDate.Name = "btn_removeDate";
            this.btn_removeDate.Size = new System.Drawing.Size(81, 37);
            this.btn_removeDate.TabIndex = 73;
            this.btn_removeDate.Text = "remove";
            this.btn_removeDate.UseVisualStyleBackColor = true;
            this.btn_removeDate.Click += new System.EventHandler(this.btn_removeDate_Click);
            // 
            // btn_addDate
            // 
            this.btn_addDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDate.ForeColor = System.Drawing.Color.Red;
            this.btn_addDate.Location = new System.Drawing.Point(547, 159);
            this.btn_addDate.Name = "btn_addDate";
            this.btn_addDate.Size = new System.Drawing.Size(57, 36);
            this.btn_addDate.TabIndex = 72;
            this.btn_addDate.Text = "add";
            this.btn_addDate.UseVisualStyleBackColor = true;
            this.btn_addDate.Click += new System.EventHandler(this.btn_addDate_Click);
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.Location = new System.Drawing.Point(453, 165);
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.Size = new System.Drawing.Size(83, 22);
            this.txtBox_Date.TabIndex = 74;
            // 
            // UpdateAndDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(703, 414);
            this.Controls.Add(this.txtBox_Date);
            this.Controls.Add(this.btn_removeDate);
            this.Controls.Add(this.btn_addDate);
            this.Controls.Add(this.comboBox_Dates);
            this.Controls.Add(this.txtBox_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeTime);
            this.Controls.Add(this.txtBox_Hour);
            this.Controls.Add(this.btn_addTime);
            this.Controls.Add(this.comboBox_Hours);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBox_Categories);
            this.Controls.Add(this.btn_removeCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtBox_Trailer);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBox_age);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_Projection);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.btn_uploadMovie);
            this.Controls.Add(this.txtBox_posterPath);
            this.Controls.Add(this.txtBox_Director);
            this.Controls.Add(this.txtBox_Duration);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.txtBox_MovieName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "UpdateAndDeleteMovie";
            this.Text = "UpdateAndDeleteMoviecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Button btn_uploadMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_removeCategory;
        private System.Windows.Forms.Button btn_removeTime;
        private System.Windows.Forms.TextBox txtBox_Hour;
        private System.Windows.Forms.Button btn_addTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBox_Trailer;
        public System.Windows.Forms.TextBox txtBox_age;
        public System.Windows.Forms.ComboBox comboBox_Projection;
        public System.Windows.Forms.TextBox txtBox_posterPath;
        public System.Windows.Forms.TextBox txtBox_Director;
        public System.Windows.Forms.TextBox txtBox_Duration;
        public System.Windows.Forms.TextBox txtBox_Price;
        public System.Windows.Forms.TextBox txtBox_MovieName;
        public System.Windows.Forms.TextBox txtBox_Categories;
        public System.Windows.Forms.ComboBox comboBox_Hours;
        public System.Windows.Forms.ComboBox comboBox_Dates;
        private System.Windows.Forms.Button btn_removeDate;
        private System.Windows.Forms.Button btn_addDate;
        public System.Windows.Forms.TextBox txtBox_Date;
    }
}