using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ManagementProduct.GUI
{
    public partial class Form_crudUsers : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=management_product;";

        public Form_crudUsers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, username, email, phone, password FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView1.Rows.Clear();
                    int i = 1;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        guna2DataGridView1.Rows.Add(i++, row["id"], row["username"], row["email"], row["phone"], row["password"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_addUsers formAddUsers = new Form_addUsers
            {
                Owner = this
            };
            formAddUsers.ShowDialog();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Jika kolom edit yang diklik
                if (e.ColumnIndex == guna2DataGridView1.Columns["dgvEdit"].Index)
                {
                    int userId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_editUsers formEditUsers = new Form_editUsers(userId);
                    formEditUsers.UserUpdated += (s, ev) => LoadData();
                    formEditUsers.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int userId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DeleteUser(userId);
                        LoadData();
                    }
                }
            }
        }

        private void DeleteUser(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
                }
            }
        }
    }
}
