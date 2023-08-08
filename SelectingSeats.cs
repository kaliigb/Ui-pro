using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cinema.Model;
using MongoDB.Driver;

namespace Cinema
{
    public partial class SelectingSeats : Form
    {
        private IMongoCollection<Movie> movies;
        private Dictionary<string, List<Seat>> seatDic;
        private string localMovieId;
        private int NumOfSeats;
        private double TotalPrice;
        private string selectedTime;
        private int selectedSeatsCount;
        public List<string> selectedSeats = new List<string>();
        private List<string> newlySelectedSeats = new List<string>();

        public SelectingSeats(IMongoCollection<Movie> movies, int numOfSeats, string movieId, double price, string selectedTime)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.movies = movies;
            this.localMovieId = movieId;
            this.selectedTime = selectedTime;
            this.NumOfSeats = numOfSeats;
            this.TotalPrice = price * numOfSeats;
            this.selectedSeatsCount = 0;

            // Update the labels with the correct values
            label_totalTickects.Text = numOfSeats.ToString();
            label_totalPrice.Text = TotalPrice.ToString();

            // Get the selected movie based on the movieId
            var filter = Builders<Model.Movie>.Filter.Eq(movie => movie.Id, localMovieId);
            List<Model.Movie> result = movies.Find(filter).ToList();
            seatDic = result.First().th.seatsAndHourDic;

            // Check if the selected hour exists in the dictionary
            if (seatDic != null && seatDic.ContainsKey(selectedTime))
            {
                // Get the seats for the selected hour
                List<Seat> seatsForSelectedHour = seatDic[selectedTime];

                // Mark occupied seats as red and disable them
                foreach (Seat seat in seatsForSelectedHour)
                {
                    Button button = GetButtonBySeat(seat.GetName().ToLower());
                    if (button != null)
                    {
                        if (seat.Occupied)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                        else
                        {
                            // Seat is available, so enable it
                            button.BackColor = SystemColors.Control;
                            button.Enabled = true;
                        }
                    }
                }
            }

            // Clear the selected seats list
            selectedSeats.Clear();

            // Repopulate the selected seats list from the seat dictionary for the selected time
            if (seatDic != null && seatDic.ContainsKey(selectedTime))
            {
                List<Seat> seatsForSelectedHour = seatDic[selectedTime];
                foreach (Seat seat in seatsForSelectedHour)
                {
                    if (seat.Occupied)
                    {
                        selectedSeats.Add(seat.GetName());
                    }
                }
            }

            // Update the buttons' background colors based on the selected seats list
            foreach (string seatName in selectedSeats)
            {
                Button button = GetButtonBySeat(seatName);
                if (button != null)
                {
                    button.BackColor = Color.LightGreen;
                }
            }

            // Create a list of all button names
            List<string> buttonNames = new List<string>
        {
            "btn_a1", "btn_a2", "btn_a3", "btn_a4", "btn_a5",
            "btn_b1", "btn_b2", "btn_b3", "btn_b4", "btn_b5",
            "btn_c1", "btn_c2", "btn_c3", "btn_c4", "btn_c5",
            "btn_d1", "btn_d2", "btn_d3", "btn_d4", "btn_d5"
        };

            // Attach the event handler to the Click event of each button
            foreach (string buttonName in buttonNames)
            {
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    string seatIdentifier = buttonName.Substring(4); // Extract the seat identifier (e.g., "A1") from the button name (e.g., "btn_a1")
                    button.Click += (sender, e) => HandleButtonClick(seatIdentifier);
                }
            }
        }

        private Button GetButtonBySeat(string seat)
        {
            // Get the button based on the seat identifier
            return this.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "btn_" + seat);
        }



        private void HandleButtonClick(string seatName)
        {
            Button button = GetButtonBySeat(seatName);
            if (button != null)
            {
                // Convert seatName to uppercase
                seatName = seatName.ToUpper();

                if (button.BackColor == Color.Red)
                {
                    // Seat is already occupied, so don't allow selection
                    MessageBox.Show("This seat is already occupied.", "Error");
                }
                else if (button.BackColor == Color.LightGreen)
                {
                    // Seat is already selected, so unselect it
                    button.BackColor = SystemColors.Control;
                    selectedSeats.Remove(seatName);
                    selectedSeatsCount--;
                }
                else
                {
                    // Check if the maximum number of seats has been reached
                    if (selectedSeatsCount >= NumOfSeats)
                    {
                        MessageBox.Show($"You can only select {NumOfSeats} seats.", "Error");
                        return;
                    }

                    // Seat is available and not selected, so select it
                    button.BackColor = Color.LightGreen;
                    selectedSeats.Add(seatName);
                    selectedSeatsCount++;
                }
            }
        }

        private void SaveSelectedSeats()
        {
            // Get the last NumOfSeats elements from the selectedSeats list
            newlySelectedSeats = selectedSeats.Skip(Math.Max(0, selectedSeats.Count - NumOfSeats)).ToList();

            // Save the selected seats to a file or database, or perform any desired action with the data
            // For demonstration purposes, let's just display the newly selected seats in a message box
            string newlySelectedSeatsMessage = "Reserved Seat Successfully, Selected Seat:\n" + string.Join(", ", newlySelectedSeats);
            MessageBox.Show(newlySelectedSeatsMessage, "Newly Selected Seat");
        }

        private void btn_confirmSeats_Click(object sender, EventArgs e)
        {
            if (selectedSeatsCount == NumOfSeats)
            {
                SaveSelectedSeats();

                // Update the occupied status of the selected seats in the seat dictionary for the selected hour
                if (seatDic != null && seatDic.ContainsKey(selectedTime))
                {
                    List<Seat> seatsForSelectedHour = seatDic[selectedTime];
                    foreach (Seat seat in seatsForSelectedHour)
                    {
                        seat.Occupied = selectedSeats.Contains(seat.GetName());
                    }

                    // Update the entire seat dictionary in the movie document
                    var filter = Builders<Movie>.Filter.Eq(movie => movie.Id, localMovieId);
                    var update = Builders<Movie>.Update.Set(movie => movie.th.seatsAndHourDic, seatDic);
                    var result = movies.UpdateOne(filter, update);

                    if (result.ModifiedCount > 0)
                    {
                        MessageBox.Show("Seat selection has been saved successfully.", "Confirmation");
                        this.Close();
                        Payment payment = new Payment(selectedSeats, localMovieId);

                        payment.txtBox_Price.Text = TotalPrice.ToString();
                        payment.txtBox_numOfTickets.Text = NumOfSeats.ToString();

                        // Get the last NumOfSeats elements from the selectedSeats list and join them with a comma
                        payment.txtBox_Seats.Text = string.Join(", ", newlySelectedSeats);

                        payment.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save seat selection.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Selected hour not found in the seat dictionary.", "Error");
                }
            }
            else
            {
                MessageBox.Show($"Please select exactly {NumOfSeats} seats.", "Error");
            }
        }





        private void btn_d1_Click(object sender, EventArgs e)
        {
            HandleButtonClick("D1");
        }

        private void btn_d2_Click(object sender, EventArgs e)
        {
            HandleButtonClick("D2");
        }

        private void btn_d3_Click(object sender, EventArgs e)
        {
            HandleButtonClick("D3");
        }

        private void btn_d4_Click(object sender, EventArgs e)
        {
            HandleButtonClick("D4");
        }

        private void btn_d5_Click(object sender, EventArgs e)
        {
            HandleButtonClick("D5");
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            HandleButtonClick("C1");
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            HandleButtonClick("C2");
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            HandleButtonClick("C3");
        }

        private void btn_c4_Click(object sender, EventArgs e)
        {
            HandleButtonClick("C4");
        }

        private void btn_c5_Click(object sender, EventArgs e)
        {
            HandleButtonClick("C5");
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            HandleButtonClick("B1");
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            HandleButtonClick("B2");
        }

        private void btn_b3_Click(object sender, EventArgs e)
        {
            HandleButtonClick("B3");
        }
        private void btn_b4_Click(object sender, EventArgs e)
        {
            HandleButtonClick("B4");
        }

        private void btn_b5_Click(object sender, EventArgs e)
        {
            HandleButtonClick("B5");
        }

        private void btn_a1_Click(object sender, EventArgs e)
        {
            HandleButtonClick("A1");
        }

        private void btn_a2_Click(object sender, EventArgs e)
        {
            HandleButtonClick("A2");
        }

        private void btn_a3_Click(object sender, EventArgs e)
        {
            HandleButtonClick("A3");
        }

        private void btn_a4_Click(object sender, EventArgs e)
        {
            HandleButtonClick("A4");
        }

        private void btn_a5_Click(object sender, EventArgs e)
        {
            HandleButtonClick("A5");
        }

    }
}


