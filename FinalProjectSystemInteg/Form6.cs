using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSystemInteg
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            password.PasswordChar = '*'; // Mask the password input
        }

        // Property to access the entered password
        public string Password => password.Text;

        private void Form6_Load(object sender, EventArgs e)
        {
            // Any initialization code if needed
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // Get the password entered by the user
            string password1 = password.Text.Trim();

            // Validate the input (password shouldn't be empty)
            if (string.IsNullOrWhiteSpace(password1))
            {
                MessageBox.Show("Please enter a password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Define the connection string
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;"))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to check if the entered password is correct
                    string query = "SELECT COUNT(*) FROM Table1 WHERE Password = @Password"; 

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add the password parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Password", password1); // Use the value of password1 here

                        // Execute the query and get the result
                        int result = (int)command.ExecuteScalar();

                        // Check if the password is correct
                        if (result > 0)
                        {
                            this.DialogResult = DialogResult.OK; // Close dialog with OK result
                            this.Close();
                        }
                        else
                        {
                            // If the password is incorrect, show error message
                            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            password.Clear(); // Optionally clear the password field for re-entry
                            password.Focus(); // Focus back to the password field
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors that occur during the connection or query
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            // Close the dialog if Cancel is clicked
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
