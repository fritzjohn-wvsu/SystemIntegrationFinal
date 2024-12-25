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
    public partial class Form5 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";
        private List<Product> cartItems = new List<Product>();
        private int transactionNumber;  // Store the transaction number
        private string receiptDateTime;  // Store the date and time once the transaction starts


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Set up DataGridView columns for displaying products (Removed Quantity and Total columns)
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("ProductName", "Product Name");
                dataGridView1.Columns.Add("Category", "Category");
                dataGridView1.Columns.Add("Stock", "Stock Quantity");
                dataGridView1.Columns.Add("Price", "Price");
            }

            // Fetch products from the database to display in the DataGridView
            FetchProductsForDisplay();
        }

        private void FetchProductsForDisplay()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, ProductName, Category, StockQuantity, Price FROM Table1";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    // Clear existing rows in the DataGridView before adding new data
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();
                        string productName = reader["ProductName"].ToString().ToUpper(); // Convert to uppercase
                        string category = reader["Category"].ToString();
                        string stockQuantity = reader["StockQuantity"].ToString();
                        string price = reader["Price"].ToString();

                        dataGridView1.Rows.Add(id, productName, category, stockQuantity, price);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product data: " + ex.Message);
            }
        }


        // Display the receipt in the Receipt label or textbox
        private void DisplayReceipt()
        {
            StringBuilder receiptText = new StringBuilder();
            double totalPrice = 0;

            // Check if the date and time have not been set yet
            if (string.IsNullOrEmpty(receiptDateTime))
            {
                // Set the receipt date and time when the first item is added
                receiptDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }

            // Append the receipt header with the transaction number and date/time
            receiptText.AppendLine($"Transaction No: {transactionNumber}");
            receiptText.AppendLine($"Receipt Date & Time: {receiptDateTime}");
            receiptText.AppendLine("-------------------------------");

            // Loop through the cart items to display each product
            foreach (var item in cartItems)
            {
                receiptText.AppendLine($"{item.PName} x{item.Quantity} - {item.Price:C2}");
                totalPrice += item.Total;
            }

            receiptText.AppendLine("-------------------------------");

            // Display the receipt text in the Receipt label or TextBox
            Receipt.Text = receiptText.ToString();

            // Update the TotalPrice label with the total amount
            TotalPrice.Text = $"Total Price: {totalPrice:C2}";
        }


        private void UpdateProductStock(Product product)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Table1 SET StockQuantity = StockQuantity - @Quantity WHERE ProductName = @ProductName";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@ProductName", product.PName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product stock: " + ex.Message);
            }
        }

        private void InsertOrderToTable3(Product product)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Table3 (TransactionNumber, ProductName, Quantity, TotalPrice, OrderDate) " +
                                   "VALUES (@TransactionNumber, @ProductName, @Quantity, @TotalPrice, @OrderDate)";

                    OleDbCommand cmd = new OleDbCommand(query, connection);

                    // Explicitly add parameters with proper types
                    cmd.Parameters.Add("@TransactionNumber", OleDbType.Integer).Value = transactionNumber;
                    cmd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = product.PName.ToUpper();
                    cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = product.Quantity;
                    cmd.Parameters.Add("@TotalPrice", OleDbType.Currency).Value = Convert.ToDecimal(product.Total);
                    cmd.Parameters.Add("@OrderDate", OleDbType.Date).Value = DateTime.Now;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting order: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Confirm_Click(object sender, EventArgs e)
        {
            string productName = Product.Text.ToUpper(); // Ensure input is in uppercase
            int quantity = 0;

            if (int.TryParse(pQuantity.Text, out quantity) && quantity > 0)
            {
                Product product = GetProductDetails(productName);

                if (product != null)
                {
                    if (quantity > product.StockQuantity)
                    {
                        MessageBox.Show("Insufficient stock! Please check the stock quantity and try again.",
                        "Stock Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }

                    if (transactionNumber == 0)
                    {
                        Random random = new Random();
                        transactionNumber = random.Next(100000, 999999);
                    }

                    var existingItem = cartItems.FirstOrDefault(item => item.PName == product.PName);

                    if (existingItem != null)
                    {
                        if (existingItem.Quantity + quantity > product.StockQuantity)
                        {
                            MessageBox.Show($"Adding {quantity} exceeds available stock! Current cart quantity: {existingItem.Quantity}, Stock: {product.StockQuantity}");
                            return;
                        }

                        existingItem.Quantity += quantity;
                        existingItem.Total = existingItem.Quantity * existingItem.Price;
                    }
                    else
                    {
                        cartItems.Add(new Product
                        {
                            PName = product.PName,
                            Price = product.Price,
                            Quantity = quantity,
                            Total = product.Price * quantity
                        });
                    }

                    DisplayReceipt();
                }
                else
                {
                    MessageBox.Show("Product does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity input! Please enter a valid positive number.");
            }
        }
        private Product GetProductDetails(string productName)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, ProductName, Price, StockQuantity FROM Table1 WHERE UCASE(ProductName) = UCASE(@ProductName)"; // Ensure case-insensitivity
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ProductName", productName.ToUpper()); // Convert input to uppercase

                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Product
                        {
                            PName = reader["ProductName"].ToString().ToUpper(), // Convert to uppercase
                            Price = Convert.ToDouble(reader["Price"]),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product details: " + ex.Message);
            }

            return null;
        }

        private void Product_TextChanged(object sender, EventArgs e)
        {

        }

        private void pQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Product.Clear();

            pQuantity.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in cartItems)
            {
                UpdateProductStock(item);
                InsertOrderToTable3(item);
            }

            MessageBox.Show("Order Completed! Thank you for shopping with us.");

            cartItems.Clear();
            Receipt.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of Form6 (password verification form)
            Form6 form6 = new Form6();

            // Show Form6 as a dialog (blocks user interaction with the previous form until it's closed)
            if (form6.ShowDialog() == DialogResult.OK)
            {
                // If the password is correct (DialogResult.OK), proceed with deleting the receipt
                DeleteReceipt();  // Call the method to delete the receipt
            }
            else
            {
                // Optionally, display a message if the password is incorrect or the user canceled
                MessageBox.Show("Password verification failed or canceled. Receipt not deleted.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteReceipt()
        {
            try
            {
                // Clear the receipt display (label or TextBox)
                Receipt.Text = string.Empty;// Clears the content from the Receipt label or TextBox

                // Clear the cart items if stored in a list (adjust based on your actual cart structure)
                cartItems.Clear(); // Assuming cartItems is a List of items; clear it to remove all items

                // Reset the total price display
                TotalPrice.Text = "Total Price: $0.00"; // Reset to default text or 0 if preferred

                // Reset the receipt date and time (if needed)
                receiptDateTime = string.Empty; // Optional: Reset the date and time to allow a new receipt creation

                // Optionally, you could reset other related variables, such as transactionNumber, if needed
                transactionNumber = 0; // Reset the transaction number if it's a new transaction

                // Show success message
                MessageBox.Show("Receipt deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during receipt deletion
                MessageBox.Show("An error occurred while deleting the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Update the stock and insert the order for each item in the cart
                foreach (var item in cartItems)
                {
                    UpdateProductStock(item);
                    InsertOrderToTable3(item);
                }

                // Show confirmation message
                MessageBox.Show("Order Completed! Thank you for shopping with us.");

                // Clear the cart and receipt
                cartItems.Clear();
                Receipt.Text = string.Empty;

                // Refresh the DataGridView to show updated product stock
                FetchProductsForDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during checkout: " + ex.Message);
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show(); this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); this.Hide();
        }
    }

    public class Product
    {
        public string PName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public int StockQuantity { get; set; } // Add stock quantity field for validation
    }
}

