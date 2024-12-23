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
                dataGridView1.Columns.Add("ID", "ID");  // This can be generated later in case you need a unique ID in the future
                dataGridView1.Columns.Add("Name", "Product Name");
                dataGridView1.Columns.Add("Category", "Category");
                dataGridView1.Columns.Add("Stock", "Stock Quantity");

                // Add Edit button column
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "EditButtonColumn";
                editButton.HeaderText = "Actions";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(editButton);

                // Add Delete button column
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "DeleteButtonColumn";
                deleteButton.HeaderText = "";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButton);
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

                // SQL query to retrieve all data from Table1 (including ID)
                string query = "SELECT ID, ProductName, Category, StockQuantity FROM Table1";
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

                    // Add the data into the DataGridView
                    dataGridView1.Rows.Add(id, productName, category, stockQuantity);  // Display the ID column
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Check if the clicked cell is in the Edit button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButtonColumn")
                {
                    string productName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    MessageBox.Show($"Edit button clicked for: {productName}");
                    // Open an Edit Form or handle the edit functionality here
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
                {
                    string productName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    var confirmResult = MessageBox.Show($"Are you sure to delete {productName}?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }
    }
}
