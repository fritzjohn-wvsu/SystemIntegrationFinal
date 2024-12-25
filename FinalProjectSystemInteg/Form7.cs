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
    public partial class Form7 : Form
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string StockQuantity { get; set; }
        public string Price { get; set; }

        // Constructor to pass values to Form7
        public Form7(string productId, string productName, string category, string stockQuantity, string price)
        {
            InitializeComponent();

            // Assign values to properties
            ProductId = productId;
            ProductName = productName;
            Category = category;
            StockQuantity = stockQuantity;
            Price = price;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Populate fields with existing product details when form loads
            productName.Text = ProductName;
            category.Text = Category;
            stockQuantity.Text = StockQuantity;
            price.Text = Price;
        }

        // Method to update product details in the database
        private bool UpdateProductInDatabase(string productId, string productName, string category, string stockQuantity, string price)
        {
            try
            {
                // Create a new connection to the database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                // Open the connection
                connection.Open();

                // SQL query to update the product details by its ID
                string query = "UPDATE Table1 SET ProductName = @ProductName, Category = @Category, StockQuantity = @StockQuantity, Price = @Price WHERE ID = @ProductId";
                OleDbCommand cmd = new OleDbCommand(query, connection);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Close the connection
                connection.Close();

                // Return true if the record was updated successfully
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
                return false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Validate Product Name (must not be empty)
            if (string.IsNullOrWhiteSpace(productName.Text))
            {
                MessageBox.Show("Product Name cannot be empty. Please provide a valid name.",
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
            if (!decimal.TryParse(price.Text, out decimal priceValue) || priceValue < 0)
            {
                MessageBox.Show("Please enter a valid price. It should be a non-negative number.",
                                "Invalid Price",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Save changes to the database if validation passes
            bool success = UpdateProductInDatabase(ProductId, productName.Text, category.Text, stockQuantity.Text, price.Text);

            if (success)
            {
                // Success message with a check mark icon and more detailed information
                MessageBox.Show("The product has been successfully updated!\n\n" +
                                $"Product Name: {productName.Text}\n" +
                                $"Category: {category.Text}\n" +
                                $"Stock Quantity: {stockQuantity.Text}\n" +
                                $"Price: {price.Text}",
                                "Update Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Close the form after successful update
                this.Close();
            }
            else
            {
                // Error message with a warning icon and more context
                MessageBox.Show("Oops! Something went wrong while updating the product. Please try again later.\n",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }



        // Click event to clear the form (not implemented yet)
        private void Clear_Click(object sender, EventArgs e)
        {
            // Clear the form if needed
        }
    }
}
      


