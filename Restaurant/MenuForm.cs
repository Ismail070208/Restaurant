using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                ClearFields();
                dgvProducts.ClearSelection();
            }
            else
            {
                tabControl1.SelectedTab = tabWaiter;
            }

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.BackColor = Color.FromArgb(245, 247, 250);
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
        C.Name AS Category,
        P.ImagePath
    FROM Products P
    INNER JOIN Categories C ON P.CategoryId = C.Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProducts.DataSource = dt;
                dgvProducts.Columns["ImagePath"].Visible = false;

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

        private void ClearFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            numPrice.Value = 0;

            cmbCategory.SelectedIndex = -1;

            picProduct.Image = null;
            imagePath = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string imagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (op.ShowDialog() == DialogResult.OK)
            {
                picProduct.Image = Image.FromFile(op.FileName);
                imagePath = op.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Products
                        (Name, Price, Description, CategoryId, ImagePath)
                        VALUES
                        (@name, @price, @desc, @cat, @img)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", numPrice.Value);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@img", imagePath);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            MessageBox.Show("Product added successfully!");
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.SelectedRows.Count == 0)
                return;

            txtName.Text = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();
            txtDescription.Text = dgvProducts.CurrentRow.Cells["Description"].Value.ToString();

            numPrice.Value = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Price"].Value);

            cmbCategory.Text = dgvProducts.CurrentRow.Cells["Category"].Value.ToString();

            string path = dgvProducts.CurrentRow.Cells["ImagePath"].Value?.ToString();

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                picProduct.Image = Image.FromFile(path);
                imagePath = path;
            }
            else
            {
                picProduct.Image = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);

            string connectionString = @"Data Source=DESKTOP-743IP50\MSSQLSERVER2022;Initial Catalog=Restaurant;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Products
                         SET Name=@name,
                             Price=@price,
                             Description=@desc,
                             CategoryId=@cat,
                             ImagePath=@img
                         WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", numPrice.Value);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@img", imagePath);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            MessageBox.Show("Product updated!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dgvProducts.ClearSelection();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

