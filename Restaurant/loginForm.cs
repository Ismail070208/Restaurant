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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;";
            string query = "SELECT Role FROM Users WHERE Username=@username AND PasswordHash=@password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                conn.Open();
                var role = cmd.ExecuteScalar();


                if (role != null)
                {
                    NavigationForm main = new NavigationForm(role.ToString());
                    main.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Invalid username or password!";
                    lblError.ForeColor = Color.Red;
                }
            }
        }
    }
}
