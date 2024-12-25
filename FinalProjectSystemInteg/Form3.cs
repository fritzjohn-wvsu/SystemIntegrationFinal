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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Prevent adding columns multiple times
            if (dataGridView1.Columns.Count == 0)
            {
                // Set up DataGridView columns
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Name", "Product Name");
                dataGridView1.Columns.Add("Category", "Category");
                dataGridView1.Columns.Add("Stock", "Stock Quantity");
                dataGridView1.Columns.Add("Price", "Price");

                // Add Delete button column
                if (!dataGridView1.Columns.Contains("DeleteButtonColumn"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "DeleteButtonColumn";
                    deleteButton.HeaderText = "Actions";
                    deleteButton.Text = "Delete";
                    deleteButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButton);
                }

                // Add Edit button column
                if (!dataGridView1.Columns.Contains("EditButtonColumn"))
                {
                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                    editButton.Name = "EditButtonColumn";
                    editButton.HeaderText = "Actions";
                    editButton.Text = "Edit";
                    editButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButton);
                }
            }

            // Clear existing rows to avoid duplication
            dataGridView1.Rows.Clear();

            // Fetch data from database
            FetchDataFromDatabase();
        }

        private void FetchDataFromDatabase()
        {
            try
            {
                // Create a new connection to the database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                // Open the connection
                connection.Open();

                // SQL query to retrieve all data from Table1
                string query = "SELECT ID, ProductName, Category, StockQuantity, Price FROM Table1";
                OleDbCommand cmd = new OleDbCommand(query, connection);

                // Execute the query and get a DataReader
                OleDbDataReader reader = cmd.ExecuteReader();

                // Read the data and add rows to the DataGridView
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string productName = reader["ProductName"].ToString();
                    string category = reader["Category"].ToString();
                    string stockQuantity = reader["StockQuantity"].ToString();
                    string price = reader["Price"].ToString();

                    // Add the data into the DataGridView
                    dataGridView1.Rows.Add(id, productName, category, stockQuantity, price);
                }

                // Close the reader and the connection
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        // Delete product from the database
        private bool DeleteProductFromDatabase(string productId)
        {
            try
            {
                // Create a new connection to the database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                // Open the connection
                connection.Open();

                // SQL query to delete the product by its ID
                string query = "DELETE FROM Table1 WHERE ID = @ProductId";
                OleDbCommand cmd = new OleDbCommand(query, connection);

                // Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@ProductId", productId);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Close the connection
                connection.Close();

                // Return true if the record was deleted successfully
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
                return false;
            }
        }

        // Handle cell click event for Delete and Edit buttons
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Check if the clicked cell is in the Delete button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
                {
                    string productName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    string productId = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    var confirmResult = MessageBox.Show($"Delete {productName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bool deletionSuccess = DeleteProductFromDatabase(productId);
                        if (deletionSuccess)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show($"{productName} deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete. Try again.");
                        }
                    }
                }
                // Check if the clicked cell is in the Edit button column
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButtonColumn")
                {
                    string productId = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    string productName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    string category = dataGridView1.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                    string stockQuantity = dataGridView1.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                    string price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();

                    // Open an edit form to modify the product details (you can implement a form to edit details here)
                    Form7 editForm = new Form7(productId, productName, category, stockQuantity, price);
                    editForm.ShowDialog();

                    // Refresh the DataGridView after editing (you can also re-fetch from the database here)
                    dataGridView1.Rows.Clear();
                    FetchDataFromDatabase();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); this.Hide();
        }
    }
}
