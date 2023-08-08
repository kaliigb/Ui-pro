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
using Cinema.Model;
using MongoDB.Driver;

namespace Cinema
{
    /// <summary>
    /// Represents the admin verification form of the Cinema application.
    /// </summary>
    public partial class AdminVerificationForm : Form
    {
        // MongoDB connection string from the configuration file.
        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        IMongoCollection<Model.Admin> Admins;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminVerificationForm"/> class.
        /// </summary>
        public AdminVerificationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Occurs when the AdminVerificationForm is loaded.
        /// </summary>
        private void AdminVerificationForm_Load(object sender, EventArgs e)
        {
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            try
            {
                MongoClient mongoClient = new MongoClient(connectionString);
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                // Get the collection of admins from the database
                Admins = db.GetCollection<Model.Admin>("Admin");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during database connection
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for the Verify button click.
        /// </summary>
        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string enteredId = txtBox_AdminId.Text;

            // Query the Admin collection for the entered ID
            var filter = Builders<Model.Admin>.Filter.Eq(admin => admin.AdminID, enteredId);
            List<Model.Admin> result = Admins.Find(filter).ToList();

            if (result.Count == 1)
            {
                // ID exists in the database, navigate to the admin interface form
                AdminInterface adminInterface = new AdminInterface();


                // Close the current form if desired
                this.Close();

                adminInterface.ShowDialog();
            }
            else
            {
                // ID does not exist in the database, display an error message or handle as desired
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
