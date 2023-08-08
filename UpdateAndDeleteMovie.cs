using Cinema.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class UpdateAndDeleteMovie : Form
    {
        IMongoCollection<Model.Movie> movies;
        public UpdateAndDeleteMovie(IMongoCollection<Model.Movie> Movie)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.movies = Movie;

        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            string category = comboBox_Category.Text;
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
            string category = comboBox_Category.Text;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Get the movie ID from the TextBox
            string movieId = txtBox_Id.Text;

            // Fetch the movie document from the MongoDB collection based on the ID
            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, movieId);
            Model.Movie movieToUpdate = movies.Find(filter).FirstOrDefault();

            if (movieToUpdate != null)
            {
                // Update the properties of the movie object with the values from the form
                movieToUpdate.MovieName = txtBox_MovieName.Text;
                movieToUpdate.MovieCategories = txtBox_Categories.Text.Split(',').Select(c => c.Trim()).ToList();
                movieToUpdate.ProjectionType = comboBox_Projection.Text;
                movieToUpdate.Price = Convert.ToDouble(txtBox_Price.Text);
                movieToUpdate.Director = txtBox_Director.Text;
                movieToUpdate.Duration = txtBox_Duration.Text;
                movieToUpdate.Poster = txtBox_posterPath.Text;
                movieToUpdate.Age = Convert.ToInt32(txtBox_age.Text);
                movieToUpdate.Trailer = txtBox_Trailer.Text;

                // Update the schedule dictionary with the hours from the ComboBox
                Dictionary<string, List<string>> scheduleDict = new Dictionary<string, List<string>>();

                // Create a list of selected dates (assuming comboBox_Dates contains multiple dates)
                List<string> selectedDates = comboBox_Dates.Items.Cast<string>().ToList();

                // Create a list of selected hours for the first selected date (assuming comboBox_Hours contains hours for the first date only)
                List<string> selectedHours = new List<string>();
                foreach (string entry in comboBox_Hours.Items)
                {
                    selectedHours.Add(entry);
                }

                // Add the list of selected hours for the first selected date to the schedule dictionary
                scheduleDict[selectedDates[0]] = selectedHours;

                movieToUpdate.Schedule = scheduleDict;

                // Update the movie document in the MongoDB collection
                var update = Builders<Model.Movie>.Update
                    .Set(movie => movie.MovieName, movieToUpdate.MovieName)
                    .Set(movie => movie.MovieCategories, movieToUpdate.MovieCategories)
                    .Set(movie => movie.ProjectionType, movieToUpdate.ProjectionType)
                    .Set(movie => movie.Price, movieToUpdate.Price)
                    .Set(movie => movie.Director, movieToUpdate.Director)
                    .Set(movie => movie.Duration, movieToUpdate.Duration)
                    .Set(movie => movie.Poster, movieToUpdate.Poster)
                    .Set(movie => movie.Schedule, movieToUpdate.Schedule)
                    .Set(movie => movie.Age, movieToUpdate.Age)
                    .Set(movie => movie.Trailer, movieToUpdate.Trailer);

                var result = movies.UpdateOne(filter, update);

                // Check if the update was successful
                if (result.IsAcknowledged && result.ModifiedCount > 0)
                {
                    MessageBox.Show("Movie updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Movie not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Get the movie ID from the TextBox
            string movieId = txtBox_Id.Text;

            // Fetch the movie document from the MongoDB collection based on the ID
            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, movieId);
            Model.Movie movieToDelete = movies.Find(filter).FirstOrDefault();

            if (movieToDelete != null)
            {
                // Delete the movie document from the MongoDB collection
                var result = movies.DeleteOne(filter);

                // Check if the delete was successful
                if (result.IsAcknowledged && result.DeletedCount > 0)
                {
                    MessageBox.Show("Movie deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Movie not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btn_uploadMovie_Click(object sender, EventArgs e)
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

        private void btn_addTime_Click(object sender, EventArgs e)
        {
            string timeToAdd = txtBox_Hour.Text.Trim();
            if (!string.IsNullOrEmpty(timeToAdd))
            {
                string[] timeComponents = timeToAdd.Split(':');

                if (timeComponents.Length == 2 && int.TryParse(timeComponents[0], out int hours) && int.TryParse(timeComponents[1], out int minutes))
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

       /* private void btn_removeDate_Click(object sender, EventArgs e)
        {
            if (comboBox_Dates.SelectedIndex != -1)
            {
                int selectedIndex = comboBox_Dates.SelectedIndex;
                comboBox_Dates.Items.RemoveAt(selectedIndex);

                // Check if there are any items left in the ComboBox
                if (comboBox_Dates.Items.Count > 0)
                {
                    // Reset the text to the first item in the ComboBox
                    comboBox_Dates.ResetText();
                    comboBox_Dates.SelectedIndex = 0; // Select the first item
                }
                else
                {
                    // If there are no items left, clear the selection and reset the text
                    comboBox_Dates.SelectedIndex = -1;
                    comboBox_Dates.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please select a date to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
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


    }

}
