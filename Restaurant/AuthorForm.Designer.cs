namespace Restaurant
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelCard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorGradient = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(144, 55);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(162, 218);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnBack);
            this.panelCard.Controls.Add(this.label6);
            this.panelCard.Controls.Add(this.label5);
            this.panelCard.Controls.Add(this.label4);
            this.panelCard.Controls.Add(this.label3);
            this.panelCard.Controls.Add(this.separatorGradient);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.picAvatar);
            this.panelCard.Location = new System.Drawing.Point(43, 21);
            this.panelCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(467, 528);
            this.panelCard.TabIndex = 1;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTHOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ismail Abdikov";
            // 
            // separatorGradient
            // 
            this.separatorGradient.BackColor = System.Drawing.Color.Transparent;
            this.separatorGradient.Location = new System.Drawing.Point(37, 357);
            this.separatorGradient.Name = "separatorGradient";
            this.separatorGradient.Size = new System.Drawing.Size(400, 6);
            this.separatorGradient.TabIndex = 3;
            this.separatorGradient.Paint += new System.Windows.Forms.PaintEventHandler(this.separatorGradient_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "📧 Email: ismail.abdikov@abv.bg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "🔗 GitHub: github.com/Ismail070208";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "📱 Phone: +359895795942";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(144, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 59);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(565, 561);
            this.Controls.Add(this.panelCard);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel separatorGradient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
    }
}