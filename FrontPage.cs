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
    /// Represents the front page form of the Cinema application.
    /// </summary>
    public partial class FrontPage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrontPage"/> class.
        /// </summary>
        public FrontPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Event handler for the click on the "Admin" button.
        /// Opens the AdminVerificationForm to verify admin credentials.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An object that contains the event data.</param>
        private void byn_Admin_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AdminVerificationForm and display it as a modal dialog
            AdminVerificationForm verificationForm = new AdminVerificationForm();
            verificationForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for the click on the "Customer" button.
        /// Opens the CustomerUserInterface form for customers to browse movies and book tickets.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An object that contains the event data.</param>
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CustomerUserInterface form and display it as a modal dialog
            CustomerUserInterface customer = new CustomerUserInterface();
            customer.ShowDialog();
        }

    }
}
