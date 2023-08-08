using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// Represents the form for updating and deleting admin records.
    /// </summary>
    public partial class UpdateAndDeleteAdmin : Form
    {
        IMongoCollection<Model.Admin> admins;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAndDeleteAdmin"/> class.
        /// </summary>
        /// <param name="adm">The MongoDB collection of admin records.</param>
        public UpdateAndDeleteAdmin(IMongoCollection<Model.Admin> adm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.admins = adm;
        }

        /// <summary>
        /// Handles the button click event for updating admin records.
        /// </summary>
        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txtBox_id.Text;

            var filter = Builders<Model.Admin>.Filter.Eq(a => a.Id, id);

            UpdateDefinition<Model.Admin> updateDefinition =
                Builders<Model.Admin>.Update.Set(a => a.AdminID, txtBox_adminId.Text)
                .Set(a => a.AdminName, txtBox_adminName.Text);

            try
            {
                UpdateResult updateResult = admins.UpdateOne(filter, updateDefinition);
                if (updateResult.IsAcknowledged && updateResult.ModifiedCount > 0)
                {
                    MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after a successful update
                }
                else
                {
                    MessageBox.Show("Update failed. No records were modified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the button click event for deleting admin records.
        /// </summary>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txtBox_id.Text;

            var filter = Builders<Model.Admin>.Filter.Eq(a => a.Id, id);

            try
            {
                DeleteResult deleteResult = admins.DeleteOne(filter);
                if (deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0)
                {
                    MessageBox.Show("Delete successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after a successful delete
                }
                else
                {
                    MessageBox.Show("Delete failed. No records were deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
