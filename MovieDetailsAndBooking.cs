using Cinema.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// Represents the form that displays movie details and allows customers to book tickets.
    /// </summary>
    public partial class MovieDetailsAndBooking : Form
    {
        IMongoCollection<Model.Movie> movies;
        private string localMovieId;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieDetailsAndBooking"/> class.
        /// </summary>
        /// <param name="Movie">The IMongoCollection containing movie data.</param>
        /// <param name="path">The YouTube video path for the movie trailer.</param>
        public MovieDetailsAndBooking(IMongoCollection<Model.Movie> Movie, string path, string movieId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.movies = Movie;
            this.localMovieId = movieId;

            // Load the YouTube video trailer using an embedded HTML
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='485' height='350' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser_Yotube.DocumentText = string.Format(html, path.Split('=')[1]);
        }

        /// <summary>
        /// Event handler for the "Book" button click.
        /// Opens the SelectingSeats form for the customer to choose seats and complete booking.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An object that contains the event data.</param>
        private void btn_book_Click(object sender, EventArgs e)
        {
            // Get the ticket price and number of tickets selected by the customer
            double price = Convert.ToDouble(txtBox_Price.Text);


            int numOfTickets = Convert.ToInt32(comboBox_nuberOfTickets.Text);
            string id = txtBox_Id.Text;

            /*
            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, localMovieId);

            List<Model.Movie> result = movies.Find(filter).ToList();

            Dictionary<string,List<Seat>> seatsAndHoursDict = result.First().th.seatsAndHourDic;
            */

            // Create a new instance of the SelectingSeats form with the necessary data and display it
            SelectingSeats selectingSeats = new SelectingSeats(movies, numOfTickets, id, price, comboBox_Hours.Text);
            this.Close();
            selectingSeats.Show();
        }

        private void comboBox_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Dates.SelectedItem != null)
            {
                string selectedDate = comboBox_Dates.SelectedItem.ToString();

                // Clear the comboBox_Hours
                comboBox_Hours.Items.Clear();

                // Get the selected movie based on the movieId
                var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, localMovieId);
                List<Model.Movie> result = movies.Find(filter).ToList();

                if (result.Count == 1)
                {
                    Dictionary<string, List<string>> scheduleDict = result.First().Schedule;

                    // Check if the selected date exists in the schedule dictionary
                    if (scheduleDict.ContainsKey(selectedDate))
                    {
                        // Add the hours of the selected date to the comboBox_Hours
                        List<string> hours = scheduleDict[selectedDate];
                        comboBox_Hours.Items.AddRange(hours.ToArray());
                    }
                }
            }
        }

    }

}


