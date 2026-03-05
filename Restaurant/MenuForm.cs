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
    public partial class MenuForm : Form
    {
        private string role;
        public MenuForm(string userRole)
        {
            InitializeComponent();
            role = userRole;
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                tabControl1.SelectedTab = tabAdmin;
                LoadCategories();
                LoadProducts();
            }
            else
            {
                tabControl1.SelectedTab = tabWaiter;
            }

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void LoadProducts()
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                P.Id,
                P.Name,
                P.Price,
                P.Description,
                C.Name AS Category
            FROM Products P
            INNER JOIN Categories C ON P.CategoryId = C.Id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProducts.DataSource = dt;
            }
        }

        private void LoadCategories()
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM Categories";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
