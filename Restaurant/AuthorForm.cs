using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Restaurant
{
    public partial class AuthorForm : Form
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
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void RoundPanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void MakeCircle(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
            pb.Region = new Region(gp);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 20, 20));
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            RoundPanel(panelCard);
            MakeCircle(picAvatar);
           // btnBack.Region = Region.FromHrgn(
           //    CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 20, 20)
           //);
        }

        private void separatorGradient_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(200, 200, 200),
            Color.FromArgb(240, 240, 240),
            LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
