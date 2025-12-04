using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class NavigationForm : Form
    {
        private string userRole;

        public NavigationForm(string role)
        {
            InitializeComponent();
            userRole = role;
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            if (userRole == "Admin")
            {
                // Администраторът вижда всичко
                btnUsers.Visible = true;   // управление на потребители
                btnReports.Visible = true; // отчети
            }
            else if (userRole == "Waiter")
            {
                // Сервитьор
                btnUsers.Visible = false;
                btnReports.Visible = false;
            }
            else if (userRole == "Bartender")
            {
                btnUsers.Visible = false;
                btnReports.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm frm = new AuthorForm();
            frm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
        }
    }
}
