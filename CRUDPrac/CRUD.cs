using System.Data;
using MySql.Data.MySqlClient;
namespace CRUDPrac
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            dataGridView.CellClick += dataGridView_CellClick;
            searchBarTxt.KeyDown += searchBarTxt_KeyDown;
            LoadData();
        }
        //Essential Loading Stuff
        /*private void CRUD_Load(object sender, EventArgs e)
        {
            LoadData();
        }*/
        private string connectionString()
        {
            return "server=localhost;user=root;password=;database=crudprac;";
        }
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM crudtest";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignore header row clicks
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                firstNameTxt.Text = row.Cells["firstName"].Value?.ToString();
                middleNameTxt.Text = row.Cells["middleName"].Value?.ToString();
                lastNameTxt.Text = row.Cells["lastName"].Value?.ToString();
                courseCmb.Text = row.Cells["course"].Value?.ToString();

                string gender = row.Cells["gender"].Value?.ToString();
                maleRadio.Checked = gender == "Male";
                femaleRadio.Checked = gender == "Female";

                if (DateTime.TryParse(row.Cells["birthday"].Value?.ToString(), out DateTime dob))
                {
                    DoBSelector.Value = dob;
                }
            }
        }

        //Components
        private void insertBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString()))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO crudtest (firstName, middleName, lastName, gender, birthday, course) " +
                                   "VALUES (@firstName, @middleName, @lastName, @gender, @birthday, @course)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstNameTxt.Text);
                        cmd.Parameters.AddWithValue("@middleName", middleNameTxt.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastNameTxt.Text);
                        cmd.Parameters.AddWithValue("@gender", maleRadio.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@birthday", DoBSelector.Value.Date);
                        cmd.Parameters.AddWithValue("@course", courseCmb.SelectedItem?.ToString());

                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update.");
                    return;
                }

                int selectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

                string firstName = firstNameTxt.Text.Trim();
                string middleName = middleNameTxt.Text.Trim();
                string lastName = lastNameTxt.Text.Trim();
                string gender = maleRadio.Checked ? "Male" : (femaleRadio.Checked ? "Female" : "");
                DateTime dob = DoBSelector.Value;
                string course = courseCmb.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString()))
                {
                    string query = @"UPDATE crudtest 
                         SET firstName = @firstName, middleName = @middleName, lastName = @lastName, 
                             gender = @gender, birthday = @birthday, course = @course 
                         WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birthday", dob);
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@id", selectedID);

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No record was updated.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            int selectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString()))
            {
                string query = "DELETE FROM crudtest WHERE ID = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Record may not exist.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while deleting: " + ex.Message);
                    }
                }
            }
        }

        /*private void clearBtn_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString()))
            {
                try
                {
                    conn.Open();

                    string query = "TRUNCATE TABLE crudtest";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Table cleared successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }*/ //IF CLEAR = TRUNCATE

        /*private void clearBtn_Click(object sender, EventArgs e) 
        {
            firstNameTxt.Clear();
            middleNameTxt.Clear();
            lastNameTxt.Clear();
            searchBarTxt.Clear();

            maleRadio.Checked = false;
            femaleRadio.Checked = false;

            DoBSelector.Value = DateTime.Now;

            courseCmb.SelectedIndex = -1;
        }*/ //IF CLEAR = CLEAR FIELDS

        //Search Component
        private void searchBarTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch(searchBarTxt.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void PerformSearch(string keyword)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString()))
            {
                string query = @"SELECT * FROM crudtest 
                         WHERE firstName LIKE @kw 
                            OR lastName LIKE @kw 
                            OR middleName LIKE @kw 
                            OR id LIKE @kw
                            OR course LIKE @kw";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Search failed: " + ex.Message);
                    }
                }
            }
        }
    }
}
