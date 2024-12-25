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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProjectSystemInteg
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            LoadDataFromTable2();  // Ensure this is called to load initial data
        }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Documents\Flower Shop.accdb;Persist Security Info=False;";

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadDataFromTable2();
        }

        private void LoadDataFromTable2()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT Username, userPass, dTime FROM Table2";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found in Table2.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns["Username"].HeaderText = "Username";
                        dataGridView1.Columns["userPass"].HeaderText = "Password";
                        dataGridView1.Columns["dTime"].HeaderText = "Date Added";
                        dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if Username or userPass are empty
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = Username.Text.Trim();
                string password = Password.Text.Trim();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Ensure the query is correct with proper table and column names
                    string query = "INSERT INTO Table2 (Username, userPass, dTime) VALUES (?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        // Correctly bind parameters with appropriate types and values
                        cmd.Parameters.Add("Username", OleDbType.VarWChar).Value = username;
                        cmd.Parameters.Add("userPass", OleDbType.VarWChar).Value = password;
                        cmd.Parameters.Add("dTime", OleDbType.Date).Value = DateTime.Now; // Current date-time

                        // Execute the insert command
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataFromTable2();  // Refresh data grid view
                ClearFields();         // Clear input fields
            }
            catch (OleDbException oleDbEx)
            {
                // Specific OleDb error handling
                MessageBox.Show($"OleDb Error: {oleDbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // General exception handling for other issues
                MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Table2 SET userPass = @userPass WHERE Username = @Username";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userPass", Password.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                LoadDataFromTable2();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Username.Text))
                {
                    MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Table2 WHERE Username = @Username";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                LoadDataFromTable2();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete all records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Table2";
                        using (OleDbCommand cmd = new OleDbCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("All records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromTable2();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting all records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            Username.Clear();
            Password.Clear();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Populate the textboxes with the selected row's values
                Username.Text = row.Cells["Username"].Value.ToString();
                Password.Text = row.Cells["userPass"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }
    }
}
