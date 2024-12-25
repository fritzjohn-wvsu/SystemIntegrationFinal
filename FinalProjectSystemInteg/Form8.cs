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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Load all data when the form loads
            LoadDataFromTable3();

            // Populate the ComboBox with filter options
            filter.Items.Add("ProductName (A-Z)");
            filter.Items.Add("ProductName (Z-A)");
            filter.Items.Add("OrderDate (Latest)");
            filter.Items.Add("OrderDate (Past)");

            // Set default filter criteria
            filter.SelectedIndex = 0; // Default to ProductName (A-Z)
        }

        private void LoadDataFromTable3(string filterColumn = "", string filterText = "", string sortOrder = "ASC")
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection())
                {
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";
                    connection.Open();

                    // Base SQL query
                    string query = "SELECT TransactionNumber, ProductName, Quantity, TotalPrice, OrderDate FROM Table3";

                    // Apply filtering only if filterText is not empty
                    if (!string.IsNullOrEmpty(filterText) && !string.IsNullOrEmpty(filterColumn))
                    {
                        query += $" WHERE {filterColumn} LIKE @FilterText";
                    }

                    // Apply sorting
                    if (!string.IsNullOrEmpty(filterColumn))
                    {
                        query += $" ORDER BY {filterColumn} {sortOrder}";
                    }

                    OleDbCommand cmd = new OleDbCommand(query, connection);

                    // Add parameter for filter text only if necessary
                    if (!string.IsNullOrEmpty(filterText) && !string.IsNullOrEmpty(filterColumn))
                    {
                        cmd.Parameters.AddWithValue("@FilterText", "%" + filterText + "%");
                    }

                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable and bind it to the DataGridView
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    // Adjust column headers if necessary
                    dataGridView1.Columns["TransactionNumber"].HeaderText = "Transaction Number";
                    dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                    dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
                    dataGridView1.Columns["TotalPrice"].HeaderText = "Total Price";
                    dataGridView1.Columns["OrderDate"].HeaderText = "Order Date";

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected filter option
            string selectedFilter = filter.SelectedItem.ToString();

            // Determine the filter column and sorting order
            string filterColumn = "";
            string sortOrder = "";

            if (selectedFilter == "ProductName (A-Z)")
            {
                filterColumn = "ProductName";
                sortOrder = "ASC";
            }
            else if (selectedFilter == "ProductName (Z-A)")
            {
                filterColumn = "ProductName";
                sortOrder = "DESC";
            }
            else if (selectedFilter == "OrderDate (Latest)")
            {
                filterColumn = "OrderDate";
                sortOrder = "DESC";
            }
            else if (selectedFilter == "OrderDate (Past)")
            {
                filterColumn = "OrderDate";
                sortOrder = "ASC";
            }

            // Get the search input
            string filterText = search.Text.Trim();

            // Reload the data based on filter criteria
            LoadDataFromTable3(filterColumn, filterText, sortOrder);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Trim and check the search text
            string searchText = search.Text.Trim();

            // Determine filter column based on selected filter
            string selectedFilter = filter.SelectedItem?.ToString();
            string filterColumn = "";

            // Get the filter column based on the selected filter
            if (selectedFilter == "ProductName (A-Z)" || selectedFilter == "ProductName (Z-A)")
            {
                filterColumn = "ProductName";
            }
            else if (selectedFilter == "OrderDate (Latest)" || selectedFilter == "OrderDate (Past)")
            {
                filterColumn = "OrderDate";
            }

            // If no valid filter column is found, show an error message
            if (string.IsNullOrEmpty(filterColumn))
            {
                MessageBox.Show(
                    "Please select a valid filter option.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // If searchText is empty, load all data from the database
            if (string.IsNullOrEmpty(searchText))
            {
                LoadDataFromTable3(filterColumn); // Load all data without filtering
            }
            else
            {
                // Reload data with the filter text and column
                LoadDataFromTable3(filterColumn, searchText);
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the clicked row's data
                string transactionNumber = dataGridView1.Rows[e.RowIndex].Cells["TransactionNumber"].Value.ToString();
                string productName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                decimal totalPrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalPrice"].Value);
                DateTime orderDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["OrderDate"].Value);

                // Optionally, show the details of the clicked order in a MessageBox
                MessageBox.Show($"Transaction Number: {transactionNumber}\nProduct: {productName}\nQuantity: {quantity}\nTotal Price: {totalPrice}\nOrder Date: {orderDate}", "Order Details");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            var result = MessageBox.Show(
                "Are you sure you want to delete all records from the database? This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection())
                    {
                        connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                        connection.Open();

                        // SQL query to delete all records
                        string query = "DELETE FROM Table3";

                        using (OleDbCommand cmd = new OleDbCommand(query, connection))
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Show success message
                            MessageBox.Show(
                                $"Successfully deleted {rowsAffected} records from the database.",
                                "Deletion Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }

                        connection.Close();
                    }

                    // Refresh the DataGridView to show an empty table
                    LoadDataFromTable3();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"An error occurred while deleting records: {ex.Message}",
                        "Deletion Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                // User canceled the operation
                MessageBox.Show(
                    "Deletion canceled. No records were removed.",
                    "Operation Canceled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the TransactionNumber from the selected row
                string transactionNumber = selectedRow.Cells["TransactionNumber"].Value.ToString();

                // Show a confirmation dialog
                var result = MessageBox.Show(
                    $"Are you sure you want to delete the selected record with Transaction Number: {transactionNumber}?",
                    "Confirm Row Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (OleDbConnection connection = new OleDbConnection())
                        {
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

                            connection.Open();

                            // SQL query to delete a specific record
                            string query = "DELETE FROM Table3 WHERE TransactionNumber = @TransactionNumber";

                            using (OleDbCommand cmd = new OleDbCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Show success message
                                    MessageBox.Show(
                                        $"Record with Transaction Number: {transactionNumber} was successfully deleted.",
                                        "Deletion Complete",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );
                                }
                                else
                                {
                                    // Show failure message
                                    MessageBox.Show(
                                        "No record was deleted. Please try again.",
                                        "Deletion Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }
                            }

                            connection.Close();
                        }

                        // Refresh the DataGridView
                        LoadDataFromTable3();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"An error occurred while deleting the record: {ex.Message}",
                            "Deletion Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                // Show a message if no row is selected
                MessageBox.Show(
                    "Please select a row to delete.",
                    "No Row Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
