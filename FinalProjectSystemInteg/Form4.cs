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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new connection to the database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                // Open the connection
                connection.Open();

                // SQL query to insert data into the table
                string query = "INSERT INTO Table1 (ProductName, Category, StockQuantity) VALUES (?, ?, ?)";

                // Create a command with the query and the connection
                OleDbCommand cmd = new OleDbCommand(query, connection);

                // Add parameters to the query
                cmd.Parameters.AddWithValue("?", productName.Text);  // TextBox for product name
                cmd.Parameters.AddWithValue("?", category.SelectedItem.ToString());  // ComboBox for category
                cmd.Parameters.AddWithValue("?", stockQuantity.Text);  // TextBox for stock quantity

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data saved successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to save data.");
                }

                // Close the connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }
    }
}
