namespace Cinema
{
    partial class MovieDetailsAndBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.pictureBox_Poster = new System.Windows.Forms.PictureBox();
            this.comboBox_nuberOfTickets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser_Yotube = new System.Windows.Forms.WebBrowser();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBox_Categories = new System.Windows.Forms.TextBox();
            this.txtBox_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Director = new System.Windows.Forms.TextBox();
            this.txtBox_Duration = new System.Windows.Forms.TextBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_MovieName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Theater = new System.Windows.Forms.TextBox();
            this.txtBox_Projection = new System.Windows.Forms.TextBox();
            this.comboBox_Dates = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(593, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 51;
            this.label1.Text = "Trailer :";
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.White;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.Red;
            this.btn_book.Location = new System.Drawing.Point(325, 397);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(246, 68);
            this.btn_book.TabIndex = 53;
            this.btn_book.Text = "Book Now";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // pictureBox_Poster
            // 
            this.pictureBox_Poster.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Poster.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox_Poster.Name = "pictureBox_Poster";
            this.pictureBox_Poster.Size = new System.Drawing.Size(1298, 523);
            this.pictureBox_Poster.TabIndex = 54;
            this.pictureBox_Poster.TabStop = false;
            // 
            // comboBox_nuberOfTickets
            // 
            this.comboBox_nuberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nuberOfTickets.FormattingEnabled = true;
            this.comboBox_nuberOfTickets.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_nuberOfTickets.Location = new System.Drawing.Point(222, 397);
            this.comboBox_nuberOfTickets.Name = "comboBox_nuberOfTickets";
            this.comboBox_nuberOfTickets.Size = new System.Drawing.Size(65, 28);
            this.comboBox_nuberOfTickets.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tickets Number :";
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(142, 52);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.ReadOnly = true;
            this.txtBox_Id.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Id.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Object ID :";
            // 
            // webBrowser_Yotube
            // 
            this.webBrowser_Yotube.Location = new System.Drawing.Point(600, 52);
            this.webBrowser_Yotube.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Yotube.Name = "webBrowser_Yotube";
            this.webBrowser_Yotube.Size = new System.Drawing.Size(680, 430);
            this.webBrowser_Yotube.TabIndex = 60;
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.Location = new System.Drawing.Point(413, 241);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Hours.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(321, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 85;
            this.label14.Text = "Time :";
            // 
            // txtBox_Categories
            // 
            this.txtBox_Categories.Location = new System.Drawing.Point(142, 185);
            this.txtBox_Categories.Name = "txtBox_Categories";
            this.txtBox_Categories.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Categories.TabIndex = 82;
            // 
            // txtBox_age
            // 
            this.txtBox_age.Location = new System.Drawing.Point(400, 300);
            this.txtBox_age.Name = "txtBox_age";
            this.txtBox_age.Size = new System.Drawing.Size(39, 22);
            this.txtBox_age.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Age :";
            // 
            // txtBox_Director
            // 
            this.txtBox_Director.Location = new System.Drawing.Point(142, 300);
            this.txtBox_Director.Name = "txtBox_Director";
            this.txtBox_Director.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Director.TabIndex = 72;
            // 
            // txtBox_Duration
            // 
            this.txtBox_Duration.Location = new System.Drawing.Point(413, 122);
            this.txtBox_Duration.Name = "txtBox_Duration";
            this.txtBox_Duration.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Duration.TabIndex = 71;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(413, 51);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Price.TabIndex = 70;
            // 
            // txtBox_MovieName
            // 
            this.txtBox_MovieName.Location = new System.Drawing.Point(142, 118);
            this.txtBox_MovieName.Name = "txtBox_MovieName";
            this.txtBox_MovieName.Size = new System.Drawing.Size(121, 22);
            this.txtBox_MovieName.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(321, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Date :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(25, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 22);
            this.label17.TabIndex = 66;
            this.label17.Text = "Director :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(317, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 65;
            this.label18.Text = "Duration :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(317, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 20);
            this.label19.TabIndex = 64;
            this.label19.Text = "Price :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(22, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 22);
            this.label20.TabIndex = 63;
            this.label20.Text = "Projection :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(22, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 22);
            this.label21.TabIndex = 62;
            this.label21.Text = "Category :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(25, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 22);
            this.label22.TabIndex = 61;
            this.label22.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Theater";
            // 
            // txtBox_Theater
            // 
            this.txtBox_Theater.Location = new System.Drawing.Point(542, 300);
            this.txtBox_Theater.Name = "txtBox_Theater";
            this.txtBox_Theater.Size = new System.Drawing.Size(39, 22);
            this.txtBox_Theater.TabIndex = 89;
            // 
            // txtBox_Projection
            // 
            this.txtBox_Projection.Location = new System.Drawing.Point(142, 245);
            this.txtBox_Projection.Name = "txtBox_Projection";
            this.txtBox_Projection.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Projection.TabIndex = 90;
            // 
            // comboBox_Dates
            // 
            this.comboBox_Dates.FormattingEnabled = true;
            this.comboBox_Dates.Location = new System.Drawing.Point(413, 185);
            this.comboBox_Dates.Name = "comboBox_Dates";
            this.comboBox_Dates.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Dates.TabIndex = 91;
            this.comboBox_Dates.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dates_SelectedIndexChanged);
            // 
            // MovieDetailsAndBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1291, 520);
            this.Controls.Add(this.comboBox_Dates);
            this.Controls.Add(this.txtBox_Projection);
            this.Controls.Add(this.txtBox_Theater);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Hours);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBox_Categories);
            this.Controls.Add(this.txtBox_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Director);
            this.Controls.Add(this.txtBox_Duration);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.txtBox_MovieName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.webBrowser_Yotube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_nuberOfTickets);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Poster);
            this.Name = "MovieDetailsAndBooking";
            this.Text = "MovieDetailsAndBooking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_book;
        public System.Windows.Forms.PictureBox pictureBox_Poster;
        private System.Windows.Forms.ComboBox comboBox_nuberOfTickets;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.WebBrowser webBrowser_Yotube;
        public System.Windows.Forms.ComboBox comboBox_Hours;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtBox_Categories;
        public System.Windows.Forms.TextBox txtBox_age;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBox_Director;
        public System.Windows.Forms.TextBox txtBox_Duration;
        public System.Windows.Forms.TextBox txtBox_Price;
        public System.Windows.Forms.TextBox txtBox_MovieName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBox_Theater;
        public System.Windows.Forms.TextBox txtBox_Projection;
        public System.Windows.Forms.ComboBox comboBox_Dates;
    }
}