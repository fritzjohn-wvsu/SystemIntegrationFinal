using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalProjectSystemInteg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                // Define connection string
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;"))
                {
                    // Open the connection
                    connection.Open();

                    // Get the username and password entered by the user
                    string username = Username.Text.Trim();
                    string password = Password.Text.Trim();

                    // Query to check the username and password in the database
                    string query = "SELECT COUNT(*) FROM Table2 WHERE Username = @Username AND Password = @Password";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query and get the result
                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                           

                            // If credentials are correct, show Form5
                            Form5 form5 = new Form5();
                            form5.Show();
                            this.Hide();
                        }
                        else
                        {
                            // If credentials are incorrect, show error message
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                // Show password
                Password.PasswordChar = '\0'; // '\0' removes the masking
            }
            else
            {
                // Hide password
                Password.PasswordChar = '*'; // '*' masks the password
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
