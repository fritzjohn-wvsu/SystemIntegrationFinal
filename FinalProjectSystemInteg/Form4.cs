using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
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
            // Validate Product Name (must not be empty)
            if (string.IsNullOrWhiteSpace(productName.Text))
            {
                MessageBox.Show("Product Name cannot be empty. Please provide a valid product name.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate Category (must be selected)
            if (category.SelectedItem == null || string.IsNullOrEmpty(category.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a valid category.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate Stock Quantity (must be a valid integer and non-negative)
            if (!int.TryParse(stockQuantity.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity. It should be a non-negative integer.",
                                "Invalid Stock Quantity",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate Price (must be a valid decimal number and non-negative)
            if (!decimal.TryParse(Price.Text, out decimal priceValue) || priceValue < 0)
            {
                MessageBox.Show("Please enter a valid price. It should be a non-negative number.",
                                "Invalid Price",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a new connection to the database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                // Open the connection
                connection.Open();

                // SQL query to insert data into the table, including Price
                string query = "INSERT INTO Table1 (ProductName, Category, StockQuantity, Price) VALUES (?, ?, ?, ?)";

                // Create a command with the query and the connection
                OleDbCommand cmd = new OleDbCommand(query, connection);

                // Add parameters to the query
                cmd.Parameters.AddWithValue("?", productName.Text);  // TextBox for product name
                cmd.Parameters.AddWithValue("?", category.SelectedItem.ToString());  // ComboBox for category
                cmd.Parameters.AddWithValue("?", stockQuantity.Text);  // TextBox for stock quantity
                cmd.Parameters.AddWithValue("?", Price.Text);  // TextBox for price

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data saved successfully.");
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
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

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
