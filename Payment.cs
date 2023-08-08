using Cinema.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// Represents the form for customer payment and booking confirmation.
    /// </summary>
    public partial class Payment : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        IMongoCollection<Model.Customer> customers;
        private string localMovieId;
        private List<string> Seats;



        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class with the specified seat information and movie ID.
        /// </summary>
        /// <param name="seats">The list of selected seats for booking.</param>
        /// <param name="movieId">The ID of the movie being booked.</param>
        public Payment(List<string> seats, string movieId)
        {
            InitializeComponent();
            this.ControlBox = false; // Disable the control box (close, minimize, maximize buttons)
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing the form
            this.MaximizeBox = false; // Disable the Maximize button
            this.MinimizeBox = false; // Disable the Minimize button
            this.Seats = seats;
            this.localMovieId = movieId;
        }

        // FormClosing event handler
        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user clicking the "X" button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Event handler for the Payment form's load event.
        /// Sets up the connection to the MongoDB database and initializes necessary data.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An object that contains the event data.</param>
        private void Payment_Load(object sender, EventArgs e)
        {
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            try
            {
                MongoClient mongoClient = new MongoClient(connectionString);
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                customers = db.GetCollection<Model.Customer>("Customer"); // Assuming you have a collection named "Customer" for customers

                // You can load additional data or perform any other actions you need for the Payment form's load event.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if the ID is nine digits
        private bool checkId(string id)
        {
            // Trim the input to remove any leading or trailing spaces
            id = id.Trim();

            // Check if the ID consists of exactly nine digits
            return id.Length == 9 && id.All(char.IsDigit);
        }

        // Check if the phone number is ten digits
        private bool checkPhoneNumber(string phoneNumber)
        {
            // Trim the input to remove any leading or trailing spaces
            phoneNumber = phoneNumber.Trim();

            // Remove any non-digit characters from the phone number
            string numericPhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Check if the numeric phone number consists of exactly ten digits
            return numericPhoneNumber.Length == 10;
        }

        /// <summary>
        /// Event handler for the "Pay" button click.
        /// Validates the entered ID and phone number and performs the payment process if they are valid.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An object that contains the event data.</param>
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (checkId(txtBox_Id.Text) && checkPhoneNumber(txtBox_PhoneNumber.Text))
            {
                // The ID and phone number are valid, create the Customer object
                Customer customer = new Customer(txtBox_Id.Text, txtBox_FullName.Text, txtBox_PhoneNumber.Text);

                // Display a message box indicating successful payment
                MessageBox.Show("Payment Successful!", "Success");

                // Insert the customer data into the database
                customers.InsertOne(customer);

                // Close the Payment form
                this.Close();
            }
            else
            {
                // Display an error message if the ID or phone number is invalid
                MessageBox.Show("Invalid ID or Phone Number.", "Error");
            }
        }
    }
}
