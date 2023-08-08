using Newtonsoft.Json;
using Cinema.Model;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using MongoDB.Bson.Serialization;
using System.Globalization;

namespace Cinema
{
    /// <summary>
    /// Represents the admin interface of the Cinema application.
    /// </summary>
    public partial class AdminInterface : Form
    {
        // MongoDB connection string from the configuration file.
        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        IMongoCollection<Model.Admin> admins;
        IMongoCollection<Model.Movie> movies;
        DataTable dataTable;
        private string selectedDate; // Declare a variable to store the selected date
        Dictionary<string, List<string>> scheduleDict;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterface"/> class.
        /// </summary>
        public AdminInterface()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Occurs when the AdminInterface form is loaded.
        /// </summary>
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            // Step 1: Initialize the MongoDB client and get the collections
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            try
            {
                MongoClient mongoClient = new MongoClient(connectionString);
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                Console.WriteLine($"Connected to database: {dbName}");

                admins = db.GetCollection<Model.Admin>("Admin");
                movies = db.GetCollection<Model.Movie>("Movie");

                if (movies == null)
                {
                    Console.WriteLine("Unable to retrieve the 'Movie' collection.");
                }

                // Step 2: Create a DataTable to hold movie information
                dataTable = new DataTable();
                dataTable.Columns.Add("_id", typeof(string));
                dataTable.Columns.Add("movieName", typeof(string));
                dataTable.Columns.Add("movieCategories", typeof(string));
                dataTable.Columns.Add("projectionType", typeof(string));
                dataTable.Columns.Add("price", typeof(decimal));
                dataTable.Columns.Add("director", typeof(string));
                dataTable.Columns.Add("duration", typeof(string));
                dataTable.Columns.Add("poster", typeof(string));
                dataTable.Columns.Add("schedule", typeof(string));
                dataTable.Columns.Add("age", typeof(int));
                dataTable.Columns.Add("trailer", typeof(string));
                dataTable.Columns.Add("theater", typeof(string));

                // Step 3: Set the DataTable as the data source for the DataGridView
                dataGridView_movies.DataSource = dataTable;

                // Step 4: Disable ability to add new rows
                dataGridView_movies.AllowUserToAddRows = false;

                // Step 5: Load the movies into the DataGridView
                loadMovies();

                // Step 6: Load the admins into the DataGridView
                loadAdmins();

                // Step 7: Create a dictionary to store the schedule for the selected movie
                scheduleDict = new Dictionary<string, List<string>>();

                // Step 8: Retrieve the schedule of the currently selected movie from the database
                if (dataGridView_movies.CurrentRow != null && dataGridView_movies.CurrentRow.Cells[0].Value != null)
                {
                    string movieId = dataGridView_movies.CurrentRow.Cells[0].Value.ToString();
                    var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, movieId);
                    List<Model.Movie> result = movies.Find(filter).ToList();

                    if (result.Count == 1)
                    {
                        scheduleDict = result.First().Schedule;
                    }
                    else
                    {
                        // Movie not found in the database or no movies left in the database
                        scheduleDict = new Dictionary<string, List<string>>();
                    }
                }
                else
                {
                    // No movie is selected in the DataGridView
                    scheduleDict = new Dictionary<string, List<string>>();
                    // Handle this case based on your application's requirements.
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Loads the list of admins from the database and updates the data grid view.
        /// </summary>
        public void loadAdmins()
        {
            dataGridView_admins.DataSource = admins.Aggregate().ToList();
        }

        /// <summary>
        /// Loads the list of movies from the database and updates the data grid view.
        /// </summary>
        public void loadMovies()
        {
            List<Model.Movie> movieList = movies.Find(_ => true).ToList();
            dataTable.Clear();

            foreach (Model.Movie movie in movieList)
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




        // Event handlers for buttons and data grid views...

        private void btn_addAdmin_Click(object sender, EventArgs e)
        {
            string adminId = txtBox_AdminId.Text;
            string adminName = txtBox_AdminName.Text;

            if (!string.IsNullOrEmpty(adminId) && !string.IsNullOrEmpty(adminName))
            {
                bool isAdminIdExists = CheckIfAdminIdExists(adminId);

                if (!isAdminIdExists)
                {
                    try
                    {
                        Model.Admin admin = new Cinema.Model.Admin(adminId, adminName);
                        admins.InsertOne(admin);
                        loadAdmins();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Id or Name Inputs");
                    }
                }
                else
                {
                    MessageBox.Show("Admin ID already exists in the database");
                }
            }
            else
            {
                MessageBox.Show("At least one of the inputs is null");
            }
            txtBox_AdminId.Clear();
            txtBox_AdminName.Clear();

        }

        private bool CheckIfAdminIdExists(string adminId)
        {
            // Assuming you are using MongoDB, modify the code accordingly for your database
            bool isAdminIdExists = admins.Find(admin => admin.AdminID == adminId).Any();
            return isAdminIdExists;
        }


        private void btn_RefreshAdminList_Click(object sender, EventArgs e)
        {
            // Reload the admins and populate the DataTable again
            loadAdmins();
        }

        private void btn_filterById_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBox_IdToSearch.Text;

                var filter = Builders<Model.Admin>.Filter.Eq(admin => admin.AdminID, id);

                List<Model.Admin> result = admins.Find(filter).ToList();

                dataGridView_admins.DataSource = result;

                txtBox_IdToSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_filterByName_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBox_NameToSearch.Text;

                var filter = Builders<Model.Admin>.Filter.Eq(admin => admin.AdminName, name);

                List<Model.Admin> result = admins.Find(filter).ToList();

                dataGridView_admins.DataSource = result;

                txtBox_NameToSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refreshMovieList_Click(object sender, EventArgs e)
        {
            // Clear the DataTable to start with an empty table
            dataTable.Clear();

            // Reload the movies and populate the DataTable again
            loadMovies();

            // Set the DataSource property of the DataGridView to refresh the view
            dataGridView_movies.DataSource = dataTable;
        }

        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtBox_MovieName.Text;
            List<string> categories = txtBox_Categories.Text.Split(',').Select(c => c.Trim()).ToList();
            string projection = comboBox_Projection.Text;
            string price = txtBox_Price.Text;
            string director = txtBox_Director.Text;
            string duration = txtBox_Duration.Text;
            string posterPath = txtBox_posterPath.Text;
            int age = Convert.ToInt32(txtBox_age.Text);
            string trailerPath = txtBox_Trailer.Text;


            if (!string.IsNullOrEmpty(movieName) &&
       !string.IsNullOrEmpty(projection) && !string.IsNullOrEmpty(price) &&
       !string.IsNullOrEmpty(director) && !string.IsNullOrEmpty(duration) &&
       !string.IsNullOrEmpty(posterPath) && comboBox_Dates.Items != null)
            {
                try
                {
                    //Get the list of selected dates from comboBox_Dates
                    List<DateTime> selectedDates = new List<DateTime>();
                    foreach (var item in comboBox_Dates.Items)
                    {
                        if (DateTime.TryParseExact(item.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            selectedDates.Add(date);
                        }
                    }

                    // Get the list of selected hours from comboBox_Hours
                    List<string> selectedHours = new List<string>();
                    foreach (var item in comboBox_Hours.Items)
                    {
                        selectedHours.Add(item.ToString());
                    }

                    // Create a dictionary with date as key and list of selected hours as value
                    Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>();

                    foreach (DateTime selectedDate in selectedDates)
                    {
                        string formattedDateString = selectedDate.ToString("dd/MM/yyyy");
                        schedule[formattedDateString] = selectedHours;
                    }


                    // Format the selected date from the dateTimePicker control
                    string formattedDate = txtBox_Date.Text;

                    // Create a new Movie object
                    Movie movie = new Movie(
                        movieName,
                        categories,
                        Convert.ToDouble(price),
                        duration,
                        schedule,
                        director,
                        projection,
                        posterPath,
                        age,
                        trailerPath,
                        movies);

                    // Insert the movie into the database
                    movies.InsertOne(movie);

                    // Reload the movie list
                    loadMovies();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid inputs or an error occurred while adding the movie: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("One or more inputs are empty or the image file is missing or no date is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_uploadMovieClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png|All Files (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtBox_posterPath.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            string category = comboBox_Categories.Text;
            string currentCategories = txtBox_Categories.Text.Trim();

            // Split the current categories by comma and remove any leading or trailing whitespace
            string[] existingCategories = currentCategories.Split(',').Select(c => c.Trim()).ToArray();

            // Check if the category already exists in the current categories
            if (!existingCategories.Contains(category))
            {
                // Add the new category to the current categories
                currentCategories += (string.IsNullOrEmpty(currentCategories) ? "" : ",") + category;
                txtBox_Categories.Text = currentCategories;
            }
        }

        private void btn_removeCategory_Click(object sender, EventArgs e)
        {
            string category = comboBox_Categories.Text;
            string currentCategories = txtBox_Categories.Text.Trim();

            // Split the current categories by comma and remove any leading or trailing whitespace
            string[] existingCategories = currentCategories.Split(',').Select(c => c.Trim()).ToArray();

            // Check if the category exists in the current categories
            if (existingCategories.Contains(category))
            {
                // Remove the category from the existing categories
                existingCategories = existingCategories.Where(c => c != category).ToArray();
                currentCategories = string.Join(", ", existingCategories);
                txtBox_Categories.Text = currentCategories;
            }
        }

        private void btn_addDate_Click(object sender, EventArgs e)
        {
            string dateToAdd = txtBox_Date.Text.Trim();

            if (!string.IsNullOrEmpty(dateToAdd))
            {
                if (DateTime.TryParseExact(dateToAdd, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedDate))
                {
                    string formattedDate = selectedDate.ToString("dd/MM/yyyy");

                    // Check if the date is already in the ComboBox_Dates before adding it again
                    if (!comboBox_Dates.Items.Contains(formattedDate))
                    {
                        // Add the formatted date to the ComboBox_Dates
                        comboBox_Dates.Items.Add(formattedDate);
                        txtBox_Date.Clear(); // Clear the TextBox after adding the date
                    }
                    else
                    {
                        MessageBox.Show("The selected date is already added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please select a valid date in the format dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_removeDate_Click(object sender, EventArgs e)
        {
            if (comboBox_Dates.SelectedIndex != -1)
            {
                int selectedIndex = comboBox_Dates.SelectedIndex;
                comboBox_Dates.Items.RemoveAt(selectedIndex);
                comboBox_Dates.SelectedIndex = -1; // Clear the selection
            }
            else
            {
                MessageBox.Show("Please select a date to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_addTime_Click(object sender, EventArgs e)
        {
            string timeToAdd = txtBox_Hour.Text.Trim();
            if (!string.IsNullOrEmpty(timeToAdd))
            {
                string[] timeComponents = timeToAdd.Split(':');

                if (timeComponents.Length == 2 &&
                     int.TryParse(timeComponents[0], out int hours) &&
                     int.TryParse(timeComponents[1], out int minutes) &&
                     hours >= 0 && hours <= 23 &&
                     minutes >= 0 && minutes <= 59)
                {
                    string formattedTime = $"{hours:D2}:{minutes:D2}";

                    // Add the formatted time to the ComboBox_Hours
                    comboBox_Hours.Items.Add(formattedTime);
                    txtBox_Hour.Clear(); // Clear the TextBox after adding the time
                }
                else
                {
                    MessageBox.Show("Invalid time format. Please use the 'hh:mm' format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a time in 'hh:mm' format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_removeTime_Click(object sender, EventArgs e)
{
    if (comboBox_Hours.SelectedIndex != -1)
    {
        int selectedIndex = comboBox_Hours.SelectedIndex;
        comboBox_Hours.Items.RemoveAt(selectedIndex);

        // Check if there are any items left in the ComboBox
        if (comboBox_Hours.Items.Count > 0)
        {
            // Reset the text to the first item in the ComboBox
            comboBox_Hours.ResetText();
            comboBox_Hours.SelectedIndex = 0; // Select the first item
        }
        else
        {
            // If there are no items left, clear the selection and reset the text
            comboBox_Hours.SelectedIndex = -1;
            comboBox_Hours.Text = string.Empty;
        }
    }
    else
    {
        MessageBox.Show("Please select a time to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}



        private void dataGridView_movies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAndDeleteMovie details = new UpdateAndDeleteMovie(movies);

            DataGridViewRow selectedRow = dataGridView_movies.CurrentRow;

            details.txtBox_Id.Text = selectedRow.Cells[0].Value.ToString();
            details.txtBox_MovieName.Text = selectedRow.Cells[1].Value.ToString();
            details.txtBox_Categories.Text = selectedRow.Cells[2].Value.ToString();
            details.comboBox_Projection.Text = selectedRow.Cells[3].Value.ToString();
            details.txtBox_Price.Text = selectedRow.Cells[4].Value.ToString();
            details.txtBox_Director.Text = selectedRow.Cells[5].Value.ToString();
            details.txtBox_Duration.Text = selectedRow.Cells[6].Value.ToString();
            details.txtBox_posterPath.Text = selectedRow.Cells[7].Value.ToString();
            details.txtBox_age.Text = selectedRow.Cells[9].Value.ToString();
            details.txtBox_Trailer.Text = selectedRow.Cells[10].Value.ToString();

            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, selectedRow.Cells[0].Value.ToString());
            List<Model.Movie> result = movies.Find(filter).ToList();

            if (result.Count == 1)
            {
                scheduleDict = result.First().Schedule;

                // Check if scheduleDict contains any keys before adding dates to the ComboBox
                if (scheduleDict.Count > 0)
                {
                    // Extract the dates from the schedule dictionary and add them to ComboBox_Dates
                    foreach (string date in scheduleDict.Keys)
                    {

                        details.comboBox_Dates.Items.Add(date);

                    }

                    // If there is at least one date, update the hours ComboBox with the corresponding hours
                    string selectedDate = details.comboBox_Dates.Items[0].ToString();
                    if (scheduleDict.TryGetValue(selectedDate, out List<string> hours))
                    {
                        // Update the hours ComboBox
                        details.comboBox_Hours.Items.Clear();
                        foreach (string hour in hours)
                        {
                            details.comboBox_Hours.Items.Add(hour);
                        }
                    }
                }
                else
                {
                    // Handle the case where scheduleDict is empty
                    MessageBox.Show("scheduleDict is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            details.Show();

            loadMovies();
        }









        private void dataGridView_admins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAndDeleteAdmin details = new UpdateAndDeleteAdmin(admins);

            details.txtBox_id.Text = dataGridView_admins.CurrentRow.Cells[0].Value.ToString();
            details.txtBox_adminId.Text = dataGridView_admins.CurrentRow.Cells[1].Value.ToString();
            details.txtBox_adminName.Text = dataGridView_admins.CurrentRow.Cells[2].Value.ToString();

            details.Show();

            loadAdmins();
        }

        private void comboBox_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Dates.SelectedIndex != -1)
            {
                // Retrieve the selected date from the ComboBox
                string selectedDateString = comboBox_Dates.SelectedItem.ToString();

                //add the hours of the selected date
                if (scheduleDict.ContainsKey(selectedDateString))
                {
                    foreach (var hour in scheduleDict[selectedDateString])
                    {
                        comboBox_Hours.Items.Add(hour);
                    }
                }
              /*  else
                {
                    MessageBox.Show("No schedule found for the selected date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }

    }




}
