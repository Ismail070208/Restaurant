namespace Restaurant
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelWaiter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            this.panelWaiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.panelWaiter);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(807, 458);
            this.panelAdmin.TabIndex = 0;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // panelWaiter
            // 
            this.panelWaiter.Controls.Add(this.label1);
            this.panelWaiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWaiter.Location = new System.Drawing.Point(0, 0);
            this.panelWaiter.Name = "panelWaiter";
            this.panelWaiter.Size = new System.Drawing.Size(807, 458);
            this.panelWaiter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.panelAdmin);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelWaiter.ResumeLayout(false);
            this.panelWaiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelWaiter;
        private System.Windows.Forms.Label label1;
    }
}