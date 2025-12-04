using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class UsersForm : Form
    {

        string saveMode = "";


        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT UserID, Username, PasswordHash, Role, DisplayName FROM Users";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cmbRole.Enabled = true;

            saveMode = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител.");
                return;
            }

            txtUsername.Text = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            txtPassword.Text = dgvUsers.SelectedRows[0].Cells["PasswordHash"].Value.ToString();
            cmbRole.Text = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cmbRole.Enabled = true;

            saveMode = "edit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            if (saveMode == "add")
            {
                string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Потребителят е добавен!");
            }
            else if (saveMode == "edit")
            {
                int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

                string query = "UPDATE Users SET Username=@u, PasswordHash=@p, Role=@r WHERE UserID=@id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Потребителят е обновен!");
            }

            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител.");
                return;
            }

            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "DELETE FROM Users WHERE UserID=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Потребителят е изтрит!");
            LoadUsers();
        }
    }
}
