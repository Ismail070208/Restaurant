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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Restaurant
{
    public partial class loginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
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

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle shadowRect = new Rectangle(
                5, 5,
                panelLogin.Width - 10,
                panelLogin.Height - 10
            );

            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                FillRoundedRectangle(e.Graphics, shadowBrush, shadowRect, 25);
            }
        }

        private void FillRoundedRectangle(Graphics g, Brush brush, Rectangle rect, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                g.FillPath(brush, path);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            panelUserLine.BackColor = Color.FromArgb(74, 115, 243);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panelUserLine.BackColor = Color.Gray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelPassLine.BackColor = Color.FromArgb(74, 115, 243);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panelPassLine.BackColor = Color.Gray;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(60, 110, 230);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(74, 115, 243);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            panelLogin.Region = Region.FromHrgn(
        CreateRoundRectRgn(
            0, 0,
            panelLogin.Width,
            panelLogin.Height,
            25, 25   // колкото по-голямо → по-заоблено
        )
    );

            // rounded buttons
            RoundButton(btnLogin, 20);
            RoundButton(btnExit, 20);
        }

        private void RoundButton(Button btn, int radius)
        {
            btn.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0, 0,
                    btn.Width,
                    btn.Height,
                    radius,
                    radius
                )
            );
        }
    }
}

