namespace Cinema
{
    partial class AdminInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_filterByName = new System.Windows.Forms.Button();
            this.btn_filterById = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_NameToSearch = new System.Windows.Forms.TextBox();
            this.txtBox_IdToSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addAdmin = new System.Windows.Forms.Button();
            this.txtBox_AdminName = new System.Windows.Forms.TextBox();
            this.txtBox_AdminId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshAdminList = new System.Windows.Forms.Button();
            this.dataGridView_admins = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox_Dates = new System.Windows.Forms.ComboBox();
            this.btn_removeDate = new System.Windows.Forms.Button();
            this.btn_addDate = new System.Windows.Forms.Button();
            this.btn_removeTime = new System.Windows.Forms.Button();
            this.txtBox_Hour = new System.Windows.Forms.TextBox();
            this.btn_addTime = new System.Windows.Forms.Button();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.txtBox_Categories = new System.Windows.Forms.TextBox();
            this.txtBox_Trailer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBox_age = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Projection = new System.Windows.Forms.ComboBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.btn_uploadMovie = new System.Windows.Forms.Button();
            this.txtBox_posterPath = new System.Windows.Forms.TextBox();
            this.txtBox_Director = new System.Windows.Forms.TextBox();
            this.txtBox_Duration = new System.Windows.Forms.TextBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_MovieName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_refreshMovieList = new System.Windows.Forms.Button();
            this.dataGridView_movies = new System.Windows.Forms.DataGridView();
            this.txtBox_Date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admins)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 769);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Functions";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 753);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Managment";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.btn_filterByName);
            this.groupBox4.Controls.Add(this.btn_filterById);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtBox_NameToSearch);
            this.groupBox4.Controls.Add(this.txtBox_IdToSearch);
            this.groupBox4.Location = new System.Drawing.Point(12, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(893, 218);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter By :";
            // 
            // btn_filterByName
            // 
            this.btn_filterByName.Location = new System.Drawing.Point(660, 110);
            this.btn_filterByName.Name = "btn_filterByName";
            this.btn_filterByName.Size = new System.Drawing.Size(150, 39);
            this.btn_filterByName.TabIndex = 11;
            this.btn_filterByName.Text = "Filter By Name";
            this.btn_filterByName.UseVisualStyleBackColor = true;
            this.btn_filterByName.Click += new System.EventHandler(this.btn_filterByName_Click);
            // 
            // btn_filterById
            // 
            this.btn_filterById.Location = new System.Drawing.Point(660, 54);
            this.btn_filterById.Name = "btn_filterById";
            this.btn_filterById.Size = new System.Drawing.Size(150, 35);
            this.btn_filterById.TabIndex = 10;
            this.btn_filterById.Text = "Filter By Id";
            this.btn_filterById.UseVisualStyleBackColor = true;
            this.btn_filterById.Click += new System.EventHandler(this.btn_filterById_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter By Admin Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filter By Admin Id :";
            // 
            // txtBox_NameToSearch
            // 
            this.txtBox_NameToSearch.Location = new System.Drawing.Point(289, 118);
            this.txtBox_NameToSearch.Name = "txtBox_NameToSearch";
            this.txtBox_NameToSearch.Size = new System.Drawing.Size(246, 27);
            this.txtBox_NameToSearch.TabIndex = 7;
            // 
            // txtBox_IdToSearch
            // 
            this.txtBox_IdToSearch.Location = new System.Drawing.Point(289, 54);
            this.txtBox_IdToSearch.Name = "txtBox_IdToSearch";
            this.txtBox_IdToSearch.Size = new System.Drawing.Size(246, 27);
            this.txtBox_IdToSearch.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_addAdmin);
            this.groupBox3.Controls.Add(this.txtBox_AdminName);
            this.groupBox3.Controls.Add(this.txtBox_AdminId);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 201);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Id :";
            // 
            // btn_addAdmin
            // 
            this.btn_addAdmin.Location = new System.Drawing.Point(660, 76);
            this.btn_addAdmin.Name = "btn_addAdmin";
            this.btn_addAdmin.Size = new System.Drawing.Size(150, 56);
            this.btn_addAdmin.TabIndex = 3;
            this.btn_addAdmin.Text = "Add Admin";
            this.btn_addAdmin.UseVisualStyleBackColor = true;
            this.btn_addAdmin.Click += new System.EventHandler(this.btn_addAdmin_Click);
            // 
            // txtBox_AdminName
            // 
            this.txtBox_AdminName.Location = new System.Drawing.Point(289, 133);
            this.txtBox_AdminName.Name = "txtBox_AdminName";
            this.txtBox_AdminName.Size = new System.Drawing.Size(246, 27);
            this.txtBox_AdminName.TabIndex = 1;
            // 
            // txtBox_AdminId
            // 
            this.txtBox_AdminId.Location = new System.Drawing.Point(289, 69);
            this.txtBox_AdminId.Name = "txtBox_AdminId";
            this.txtBox_AdminId.Size = new System.Drawing.Size(246, 27);
            this.txtBox_AdminId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btn_RefreshAdminList);
            this.groupBox2.Controls.Add(this.dataGridView_admins);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 251);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load Admin List";
            // 
            // btn_RefreshAdminList
            // 
            this.btn_RefreshAdminList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshAdminList.Location = new System.Drawing.Point(295, 179);
            this.btn_RefreshAdminList.Name = "btn_RefreshAdminList";
            this.btn_RefreshAdminList.Size = new System.Drawing.Size(247, 47);
            this.btn_RefreshAdminList.TabIndex = 1;
            this.btn_RefreshAdminList.Text = "Refresh Admin List";
            this.btn_RefreshAdminList.UseVisualStyleBackColor = true;
            this.btn_RefreshAdminList.Click += new System.EventHandler(this.btn_RefreshAdminList_Click);
            // 
            // dataGridView_admins
            // 
            this.dataGridView_admins.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_admins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admins.Location = new System.Drawing.Point(179, 23);
            this.dataGridView_admins.Name = "dataGridView_admins";
            this.dataGridView_admins.RowHeadersWidth = 51;
            this.dataGridView_admins.RowTemplate.Height = 24;
            this.dataGridView_admins.Size = new System.Drawing.Size(503, 150);
            this.dataGridView_admins.TabIndex = 0;
            this.dataGridView_admins.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_admins_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies Management";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(16, 294);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(879, 420);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Movies";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBox_Date);
            this.groupBox7.Controls.Add(this.comboBox_Dates);
            this.groupBox7.Controls.Add(this.btn_removeDate);
            this.groupBox7.Controls.Add(this.btn_addDate);
            this.groupBox7.Controls.Add(this.btn_removeTime);
            this.groupBox7.Controls.Add(this.txtBox_Hour);
            this.groupBox7.Controls.Add(this.btn_addTime);
            this.groupBox7.Controls.Add(this.comboBox_Hours);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.btn_removeCategory);
            this.groupBox7.Controls.Add(this.btn_addCategory);
            this.groupBox7.Controls.Add(this.txtBox_Categories);
            this.groupBox7.Controls.Add(this.txtBox_Trailer);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtBox_age);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.comboBox_Projection);
            this.groupBox7.Controls.Add(this.comboBox_Categories);
            this.groupBox7.Controls.Add(this.btn_addMovie);
            this.groupBox7.Controls.Add(this.btn_uploadMovie);
            this.groupBox7.Controls.Add(this.txtBox_posterPath);
            this.groupBox7.Controls.Add(this.txtBox_Director);
            this.groupBox7.Controls.Add(this.txtBox_Duration);
            this.groupBox7.Controls.Add(this.txtBox_Price);
            this.groupBox7.Controls.Add(this.txtBox_MovieName);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.ForeColor = System.Drawing.Color.Red;
            this.groupBox7.Location = new System.Drawing.Point(24, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(831, 381);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add Movies Using Fields :";
            // 
            // comboBox_Dates
            // 
            this.comboBox_Dates.FormattingEnabled = true;
            this.comboBox_Dates.Location = new System.Drawing.Point(355, 130);
            this.comboBox_Dates.Name = "comboBox_Dates";
            this.comboBox_Dates.Size = new System.Drawing.Size(150, 28);
            this.comboBox_Dates.TabIndex = 45;
            this.comboBox_Dates.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dates_SelectedIndexChanged);
            // 
            // btn_removeDate
            // 
            this.btn_removeDate.Location = new System.Drawing.Point(718, 124);
            this.btn_removeDate.Name = "btn_removeDate";
            this.btn_removeDate.Size = new System.Drawing.Size(94, 38);
            this.btn_removeDate.TabIndex = 44;
            this.btn_removeDate.Text = "remove";
            this.btn_removeDate.UseVisualStyleBackColor = true;
            this.btn_removeDate.Click += new System.EventHandler(this.btn_removeDate_Click);
            // 
            // btn_addDate
            // 
            this.btn_addDate.Location = new System.Drawing.Point(628, 126);
            this.btn_addDate.Name = "btn_addDate";
            this.btn_addDate.Size = new System.Drawing.Size(84, 38);
            this.btn_addDate.TabIndex = 43;
            this.btn_addDate.Text = "add";
            this.btn_addDate.UseVisualStyleBackColor = true;
            this.btn_addDate.Click += new System.EventHandler(this.btn_addDate_Click);
            // 
            // btn_removeTime
            // 
            this.btn_removeTime.Location = new System.Drawing.Point(718, 182);
            this.btn_removeTime.Name = "btn_removeTime";
            this.btn_removeTime.Size = new System.Drawing.Size(94, 38);
            this.btn_removeTime.TabIndex = 42;
            this.btn_removeTime.Text = "remove";
            this.btn_removeTime.UseVisualStyleBackColor = true;
            this.btn_removeTime.Click += new System.EventHandler(this.btn_removeTime_Click);
            // 
            // txtBox_Hour
            // 
            this.txtBox_Hour.Location = new System.Drawing.Point(511, 189);
            this.txtBox_Hour.Name = "txtBox_Hour";
            this.txtBox_Hour.Size = new System.Drawing.Size(111, 27);
            this.txtBox_Hour.TabIndex = 41;
            // 
            // btn_addTime
            // 
            this.btn_addTime.Location = new System.Drawing.Point(628, 182);
            this.btn_addTime.Name = "btn_addTime";
            this.btn_addTime.Size = new System.Drawing.Size(84, 38);
            this.btn_addTime.TabIndex = 40;
            this.btn_addTime.Text = "add";
            this.btn_addTime.UseVisualStyleBackColor = true;
            this.btn_addTime.Click += new System.EventHandler(this.btn_addTime_Click);
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.Location = new System.Drawing.Point(355, 190);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(150, 28);
            this.comboBox_Hours.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(250, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Time :";
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Location = new System.Drawing.Point(718, 248);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(94, 38);
            this.btn_removeCategory.TabIndex = 36;
            this.btn_removeCategory.Text = "remove";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(628, 248);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(84, 38);
            this.btn_addCategory.TabIndex = 35;
            this.btn_addCategory.Text = "add";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // txtBox_Categories
            // 
            this.txtBox_Categories.Location = new System.Drawing.Point(355, 254);
            this.txtBox_Categories.Name = "txtBox_Categories";
            this.txtBox_Categories.Size = new System.Drawing.Size(150, 27);
            this.txtBox_Categories.TabIndex = 34;
            // 
            // txtBox_Trailer
            // 
            this.txtBox_Trailer.Location = new System.Drawing.Point(355, 85);
            this.txtBox_Trailer.Name = "txtBox_Trailer";
            this.txtBox_Trailer.Size = new System.Drawing.Size(428, 27);
            this.txtBox_Trailer.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Trailer :";
            // 
            // txtBox_age
            // 
            this.txtBox_age.Location = new System.Drawing.Point(113, 274);
            this.txtBox_age.Name = "txtBox_age";
            this.txtBox_age.Size = new System.Drawing.Size(39, 27);
            this.txtBox_age.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Age :";
            // 
            // comboBox_Projection
            // 
            this.comboBox_Projection.FormattingEnabled = true;
            this.comboBox_Projection.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4DX"});
            this.comboBox_Projection.Location = new System.Drawing.Point(113, 84);
            this.comboBox_Projection.Name = "comboBox_Projection";
            this.comboBox_Projection.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Projection.TabIndex = 25;
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Items.AddRange(new object[] {
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
            this.comboBox_Categories.Location = new System.Drawing.Point(511, 254);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(111, 28);
            this.comboBox_Categories.TabIndex = 24;
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.BackColor = System.Drawing.Color.White;
            this.btn_addMovie.ForeColor = System.Drawing.Color.Red;
            this.btn_addMovie.Location = new System.Drawing.Point(279, 312);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(260, 53);
            this.btn_addMovie.TabIndex = 23;
            this.btn_addMovie.Text = "Add Movie";
            this.btn_addMovie.UseVisualStyleBackColor = false;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // btn_uploadMovie
            // 
            this.btn_uploadMovie.Location = new System.Drawing.Point(668, 30);
            this.btn_uploadMovie.Name = "btn_uploadMovie";
            this.btn_uploadMovie.Size = new System.Drawing.Size(115, 43);
            this.btn_uploadMovie.TabIndex = 22;
            this.btn_uploadMovie.Text = "Upload";
            this.btn_uploadMovie.UseVisualStyleBackColor = true;
            this.btn_uploadMovie.Click += new System.EventHandler(this.btn_uploadMovieClick);
            // 
            // txtBox_posterPath
            // 
            this.txtBox_posterPath.Location = new System.Drawing.Point(355, 30);
            this.txtBox_posterPath.Name = "txtBox_posterPath";
            this.txtBox_posterPath.Size = new System.Drawing.Size(306, 27);
            this.txtBox_posterPath.TabIndex = 14;
            // 
            // txtBox_Director
            // 
            this.txtBox_Director.Location = new System.Drawing.Point(113, 229);
            this.txtBox_Director.Name = "txtBox_Director";
            this.txtBox_Director.Size = new System.Drawing.Size(121, 27);
            this.txtBox_Director.TabIndex = 13;
            // 
            // txtBox_Duration
            // 
            this.txtBox_Duration.Location = new System.Drawing.Point(113, 180);
            this.txtBox_Duration.Name = "txtBox_Duration";
            this.txtBox_Duration.Size = new System.Drawing.Size(121, 27);
            this.txtBox_Duration.TabIndex = 12;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(113, 133);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(121, 27);
            this.txtBox_Price.TabIndex = 11;
            // 
            // txtBox_MovieName
            // 
            this.txtBox_MovieName.Location = new System.Drawing.Point(113, 30);
            this.txtBox_MovieName.Name = "txtBox_MovieName";
            this.txtBox_MovieName.Size = new System.Drawing.Size(121, 27);
            this.txtBox_MovieName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Poster :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Director :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Duration :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Projection :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_refreshMovieList);
            this.groupBox5.Controls.Add(this.dataGridView_movies);
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(16, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(879, 266);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Load Movies List";
            // 
            // btn_refreshMovieList
            // 
            this.btn_refreshMovieList.BackColor = System.Drawing.Color.White;
            this.btn_refreshMovieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshMovieList.Location = new System.Drawing.Point(303, 199);
            this.btn_refreshMovieList.Name = "btn_refreshMovieList";
            this.btn_refreshMovieList.Size = new System.Drawing.Size(260, 45);
            this.btn_refreshMovieList.TabIndex = 1;
            this.btn_refreshMovieList.Text = "Refresh Movies List";
            this.btn_refreshMovieList.UseVisualStyleBackColor = false;
            this.btn_refreshMovieList.Click += new System.EventHandler(this.btn_refreshMovieList_Click);
            // 
            // dataGridView_movies
            // 
            this.dataGridView_movies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_movies.Location = new System.Drawing.Point(16, 32);
            this.dataGridView_movies.Name = "dataGridView_movies";
            this.dataGridView_movies.RowHeadersWidth = 51;
            this.dataGridView_movies.RowTemplate.Height = 24;
            this.dataGridView_movies.Size = new System.Drawing.Size(857, 161);
            this.dataGridView_movies.TabIndex = 0;
            this.dataGridView_movies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_movies_CellDoubleClick);
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.Location = new System.Drawing.Point(511, 130);
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.Size = new System.Drawing.Size(111, 27);
            this.txtBox_Date.TabIndex = 46;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(962, 803);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admins)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_admins;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addAdmin;
        private System.Windows.Forms.TextBox txtBox_AdminName;
        private System.Windows.Forms.TextBox txtBox_AdminId;
        private System.Windows.Forms.Button btn_RefreshAdminList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_filterByName;
        private System.Windows.Forms.Button btn_filterById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_NameToSearch;
        private System.Windows.Forms.TextBox txtBox_IdToSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_refreshMovieList;
        private System.Windows.Forms.DataGridView dataGridView_movies;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_posterPath;
        private System.Windows.Forms.TextBox txtBox_Director;
        private System.Windows.Forms.TextBox txtBox_Duration;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.TextBox txtBox_MovieName;
        private System.Windows.Forms.Button btn_addMovie;
        private System.Windows.Forms.Button btn_uploadMovie;
        private System.Windows.Forms.ComboBox comboBox_Projection;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.TextBox txtBox_age;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBox_Trailer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.TextBox txtBox_Categories;
        private System.Windows.Forms.Button btn_removeCategory;
        private System.Windows.Forms.Button btn_removeTime;
        private System.Windows.Forms.TextBox txtBox_Hour;
        private System.Windows.Forms.Button btn_addTime;
        private System.Windows.Forms.ComboBox comboBox_Hours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_Dates;
        private System.Windows.Forms.Button btn_removeDate;
        private System.Windows.Forms.Button btn_addDate;
        private System.Windows.Forms.TextBox txtBox_Date;
    }
}