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
        private Button activeButton = null;

        public NavigationForm(string role)
        {
            InitializeComponent();
            userRole = role;
            ApplyRolePermissions();
        }

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != activeButton)
                btn.BackColor = Color.FromArgb(60, 110, 230);
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != activeButton)
                btn.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void SetActiveButton(Button btn)
        {
            if (activeButton != null)
                activeButton.BackColor = Color.FromArgb(40, 40, 40); // normal

            activeButton = btn;
            activeButton.BackColor = Color.FromArgb(60, 110, 230); // active
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
            SetActiveButton((Button)sender);
            MenuForm form = new MenuForm();
            form.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            ReportsForm form = new ReportsForm();
            form.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            AuthorForm frm = new AuthorForm();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            UsersForm frm = new UsersForm();
            frm.ShowDialog();
        }

        private void panelNavigation_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void NavigationForm_Load(object sender, EventArgs e)
        {
            panelNavigation.BackColor = Color.FromArgb(40, 40, 40);
            btnMenu.BackColor = Color.FromArgb(40, 40, 40);
            btnOrders.BackColor = Color.FromArgb(40, 40, 40);
            btnAuthor.BackColor = Color.FromArgb(40, 40, 40);
            btnExit.BackColor = Color.FromArgb(40, 40, 40);
            btnStatistics.BackColor = Color.FromArgb(40, 40, 40);
            btnReports.BackColor = Color.FromArgb(40, 40, 40);
            btnUsers.BackColor = Color.FromArgb(40, 40, 40);
            //panel1.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btnMenu_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            StatisticsForm frm = new StatisticsForm();
            frm.ShowDialog();
        }
    }
}
