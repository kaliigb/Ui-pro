using Cinema.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// Represents the customer user interface of the Cinema application.
    /// </summary>
    public partial class CustomerUserInterface : Form
    {
        // MongoDB connection string from the configuration file.
        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        IMongoCollection<Model.Movie> movies;
        DataTable dataTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUserInterface"/> class.
        /// </summary>
        public CustomerUserInterface()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Occurs when the CustomerUserInterface form is loaded.
        /// </summary>
        private void CustomerUserInterface_Load(object sender, EventArgs e)
        {
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            try
            {
                MongoClient mongoClient = new MongoClient(connectionString);
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                Console.WriteLine($"Connected to database: {dbName}");
                movies = db.GetCollection<Model.Movie>("Movie");

                if (movies == null)
                {
                    Console.WriteLine("Unable to retrieve the 'Movie' collection.");
                }

                dataTable = new DataTable();
                // Define the columns in the DataTable
                dataTable.Columns.Add("_id", typeof(string)); // Adjust the data type if necessary
                dataTable.Columns.Add("movieName", typeof(string));
                dataTable.Columns.Add("movieCategories", typeof(string));
                dataTable.Columns.Add("projectionType", typeof(string));
                dataTable.Columns.Add("price", typeof(decimal)); // Adjust the data type if necessary
                dataTable.Columns.Add("director", typeof(string));
                dataTable.Columns.Add("duration", typeof(string)); // Adjust the data type if necessary
                dataTable.Columns.Add("poster", typeof(string));
                dataTable.Columns.Add("schedule", typeof(string)); // Use string type for schedule
                dataTable.Columns.Add("age", typeof(int)); // Adjust the data type if necessary
                dataTable.Columns.Add("trailer", typeof(string));
                dataTable.Columns.Add("theater", typeof(string));

                // After setting the DataTable as the data source for the DataGridView
                dataGridView_moviesList.DataSource = dataTable;

                // Disable ability to add new rows
                dataGridView_moviesList.AllowUserToAddRows = false;

                loadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }


            /// <summary>
            /// Loads the list of movies from the database and updates the data grid view.
            /// </summary>
        public void loadMovies()
        {
            List<Model.Movie> movieList = movies.Find(_ => true).ToList();
            dataTable.Clear();

            /*  foreach (Model.Movie movie in movieList)
              {
                    if (movie != null)
                    {
                        DataRow row = dataTable.NewRow();
                        row["_id"] = movie.Id;
                        row["movieName"] = movie.MovieName;
                        row["movieCategories"] = string.Join(", ", movie.MovieCategories);
                        row["projectionType"] = movie.ProjectionType;
                        row["price"] = movie.Price;
                        row["director"] = movie.Director;
                        row["duration"] = movie.Duration;
                        row["poster"] = movie.Poster;
                        row["schedule"] = FormatSchedule(movie.Schedule); // Format the schedule dictionary as a string
                        row["age"] = movie.Age;
                        row["trailer"] = movie.Trailer;
                        row["theater"] = movie.TheaterName;
                        dataTable.Rows.Add(row);
                    }
              }*/
            updateView(movieList);

        }

        // Custom method to format the Schedule dictionary as a string
        private string FormatSchedule(Dictionary<string, List<string>> schedule)
        {
            if (schedule == null || schedule.Count == 0)
            {
                return "No schedule available";
            }

            List<string> scheduleStrings = new List<string>();
            foreach (var entry in schedule)
            {
                string dateStr = DateTime.ParseExact(entry.Key, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                string timesStr = string.Join(", ", entry.Value);
                scheduleStrings.Add($"{dateStr}: {timesStr}");
            }

            return string.Join("; ", scheduleStrings);
        }

        private void btn_RefreshMovieList_Click(object sender, EventArgs e)
        {
            checkBox_2d.Checked = false;
            checkBox_3d.Checked = false;
            checkBox_4dx.Checked = false;
            comboBox_Category.SelectedIndex = -1;
            txtBox_filterByAge.Text = "";
            txtBox_filterByName.Text = "";

            // Clear the DataTable to start with an empty table
            dataTable.Clear();

            // Reload the movies and populate the DataTable again
            loadMovies();

            // Set the DataSource property of the DataGridView to refresh the view
            dataGridView_moviesList.DataSource = dataTable;
        }

        private void checkBox_2d_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_2d.Checked)
            {
                // Uncheck the other checkboxes
                checkBox_3d.Checked = false;
                checkBox_4dx.Checked = false;

                string projection = checkBox_2d.Text;

                var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.ProjectionType, projection);

                List<Model.Movie> result = movies.Find(filter).ToList();

                updateView(result);

            }
        }

        private void checkBox_3d_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_3d.Checked)
            {
                // Uncheck the other checkboxes
                checkBox_2d.Checked = false;
                checkBox_4dx.Checked = false;

                string projection = checkBox_3d.Text;

                var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.ProjectionType, projection);

                List<Model.Movie> result = movies.Find(filter).ToList();

                updateView(result);

            }
        }

        private void checkBox_4dx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_4dx.Checked)
            {
                // Uncheck the other checkboxes
                checkBox_2d.Checked = false;
                checkBox_3d.Checked = false;

                string projection = checkBox_4dx.Text;

                var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.ProjectionType, projection);

                List<Model.Movie> result = movies.Find(filter).ToList();

                updateView(result);

            }
        }

        private void btn_filterByName_Click(object sender, EventArgs e)
        {
            checkBox_2d.Checked = false;
            checkBox_3d.Checked = false;
            checkBox_4dx.Checked = false;
            txtBox_filterByAge.Text = "";
            comboBox_Category.SelectedIndex = -1;

            string name = txtBox_filterByName.Text;

            // Create a case-insensitive regular expression for the movie name
            var regex = new BsonRegularExpression(name, "i");

            // Use the regex filter to perform a case-insensitive search
            var filter = Builders<Model.Movie>.Filter.Regex(movie => movie.MovieName, regex);

            List<Model.Movie> result = movies.Find(filter).ToList();

            updateView(result);

        }




        private void btn_filterByCategory_Click(object sender, EventArgs e)
        {
            checkBox_2d.Checked = false;
            checkBox_3d.Checked = false;
            checkBox_4dx.Checked = false;
            txtBox_filterByAge.Text = "";
            txtBox_filterByName.Text = "";

            string category = comboBox_Category.Text;

            var filter = Builders<Model.Movie>.Filter.AnyEq(movie => movie.MovieCategories, category);

            List<Model.Movie> result = movies.Find(filter).ToList();

            updateView(result);

        }


        private void btn_Gte_Click(object sender, EventArgs e)
        {
            checkBox_2d.Checked = false; checkBox_3d.Checked = false; checkBox_4dx.Checked = false;
            comboBox_Category.SelectedIndex = -1;
            txtBox_filterByName.Text = "";

            string age = txtBox_filterByAge.Text;

            var filter = Builders<Model.Movie>.Filter.Gte(movie => movie.Age, Convert.ToInt32(age));

            List<Model.Movie> result = movies.Find(filter).ToList();

            updateView(result);

        }

        private void btn_Lte_Click(object sender, EventArgs e)
        {
            checkBox_2d.Checked = false; checkBox_3d.Checked = false; checkBox_4dx.Checked = false;
            comboBox_Category.SelectedIndex = -1;
            txtBox_filterByName.Text = "";

            string age = txtBox_filterByAge.Text;

            var filter = Builders<Model.Movie>.Filter.Lte(movie => movie.Age, Convert.ToInt32(age));

            List<Model.Movie> result = movies.Find(filter).ToList();

            updateView(result);
        }


        private void dataGridView_moviesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string trailerPath = dataGridView_moviesList.CurrentRow.Cells[10].Value.ToString();
            string movieId = dataGridView_moviesList.CurrentRow.Cells[0].Value.ToString();
            MovieDetailsAndBooking booking = new MovieDetailsAndBooking(movies, trailerPath, movieId);

            booking.txtBox_Id.Text = movieId;
            booking.txtBox_MovieName.Text = dataGridView_moviesList.CurrentRow.Cells[1].Value.ToString();
            booking.txtBox_Categories.Text = dataGridView_moviesList.CurrentRow.Cells[2].Value.ToString();
            booking.txtBox_Projection.Text = dataGridView_moviesList.CurrentRow.Cells[3].Value.ToString();
            booking.txtBox_Price.Text = dataGridView_moviesList.CurrentRow.Cells[4].Value.ToString();
            booking.txtBox_Director.Text = dataGridView_moviesList.CurrentRow.Cells[5].Value.ToString();
            booking.txtBox_Duration.Text = dataGridView_moviesList.CurrentRow.Cells[6].Value.ToString();
            string imageUrl = dataGridView_moviesList.CurrentRow.Cells[7].Value.ToString();
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    booking.pictureBox_Poster.Image = Image.FromFile(imageUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the movie poster: " + ex.Message, "Error");
                }
            }

            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, dataGridView_moviesList.CurrentRow.Cells[0].Value.ToString());
            List<Model.Movie> result = movies.Find(filter).ToList();

            if (result.Count == 1)
            {
                Dictionary<string, List<string>> scheduleDict = result.First().Schedule;

                booking.comboBox_Dates.Items.Clear();

                // Add all the dates to comboBox_Dates
                foreach (string date in scheduleDict.Keys)
                {
                    booking.comboBox_Dates.Items.Add(date);
                }

                booking.txtBox_age.Text = dataGridView_moviesList.CurrentRow.Cells[9].Value.ToString();
                booking.txtBox_Theater.Text = dataGridView_moviesList.CurrentRow.Cells[11].Value.ToString();

                booking.Show();
            }
        }



        public void updateView(List<Model.Movie> result)
        {//Function that recieve a list of movies and show it in the dataGridView

            // Clear the DataTable to start with an empty table
            dataTable.Clear();

            // Populate the DataTable again with the filtered result
            foreach (Model.Movie movie in result)
            {
                if (movie != null)
                {
                    DataRow row = dataTable.NewRow();
                    row["_id"] = movie.Id;
                    row["movieName"] = movie.MovieName;
                    row["movieCategories"] = string.Join(", ", movie.MovieCategories);
                    row["projectionType"] = movie.ProjectionType;
                    row["price"] = movie.Price;
                    row["director"] = movie.Director;
                    row["duration"] = movie.Duration;
                    row["poster"] = movie.Poster;
                    row["schedule"] = FormatSchedule(movie.Schedule); // Format the schedule dictionary as a string
                    row["age"] = movie.Age;
                    row["trailer"] = movie.Trailer;
                    row["theater"] = movie.TheaterName;
                    dataTable.Rows.Add(row);
                }
            }

            // Set the DataSource property of the DataGridView to refresh the view
            dataGridView_moviesList.DataSource = dataTable;

            // After binding the data, set the "schedule" column to use a TextBoxCell type
            dataGridView_moviesList.Columns["schedule"].CellTemplate = new DataGridViewTextBoxCell();

        }


    }
}
