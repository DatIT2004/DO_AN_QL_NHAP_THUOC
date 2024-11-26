namespace Quanlynhapthuoc
{
    partial class frm_NhanVienQLKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVienQLKho));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buLogout = new Guna.UI2.WinForms.Guna2Button();
            this.buThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.guilabelTenDN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucThuoc2 = new Quanlynhapthuoc.NguoiQL.UCThuoc();
            this.uC_Hienthi2 = new Quanlynhapthuoc.UC_Hienthi();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.buLogout);
            this.guna2Panel1.Controls.Add(this.buThuoc);
            this.guna2Panel1.Controls.Add(this.guilabelTenDN);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(242, 759);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(239, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 621);
            this.panel1.TabIndex = 1;
            // 
            // buLogout
            // 
            this.buLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buLogout.FillColor = System.Drawing.Color.Gray;
            this.buLogout.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buLogout.ForeColor = System.Drawing.Color.White;
            this.buLogout.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.buLogout.HoverState.FillColor = System.Drawing.Color.Silver;
            this.buLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.buLogout.Image = ((System.Drawing.Image)(resources.GetObject("buLogout.Image")));
            this.buLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.buLogout.Location = new System.Drawing.Point(0, 375);
            this.buLogout.Name = "buLogout";
            this.buLogout.Size = new System.Drawing.Size(242, 51);
            this.buLogout.TabIndex = 2;
            this.buLogout.Text = "     Log out";
            this.buLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buLogout.Click += new System.EventHandler(this.buLogout_Click_1);
            // 
            // buThuoc
            // 
            this.buThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buThuoc.FillColor = System.Drawing.Color.Gray;
            this.buThuoc.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buThuoc.ForeColor = System.Drawing.Color.White;
            this.buThuoc.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.buThuoc.HoverState.FillColor = System.Drawing.Color.Silver;
            this.buThuoc.HoverState.ForeColor = System.Drawing.Color.Black;
            this.buThuoc.Image = ((System.Drawing.Image)(resources.GetObject("buThuoc.Image")));
            this.buThuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buThuoc.ImageSize = new System.Drawing.Size(55, 65);
            this.buThuoc.Location = new System.Drawing.Point(-6, 261);
            this.buThuoc.Name = "buThuoc";
            this.buThuoc.Size = new System.Drawing.Size(248, 63);
            this.buThuoc.TabIndex = 2;
            this.buThuoc.Text = "Thông tin Thuốc";
            this.buThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buThuoc.Click += new System.EventHandler(this.buThuoc_Click);
            // 
            // guilabelTenDN
            // 
            this.guilabelTenDN.AutoSize = false;
            this.guilabelTenDN.BackColor = System.Drawing.Color.Transparent;
            this.guilabelTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guilabelTenDN.ForeColor = System.Drawing.Color.White;
            this.guilabelTenDN.Location = new System.Drawing.Point(29, 211);
            this.guilabelTenDN.Name = "guilabelTenDN";
            this.guilabelTenDN.Size = new System.Drawing.Size(239, 54);
            this.guilabelTenDN.TabIndex = 1;
            this.guilabelTenDN.Text = ".";
            this.guilabelTenDN.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.guilabelTenDN.UseSystemCursors = true;
            this.guilabelTenDN.Click += new System.EventHandler(this.guilabelTenDN_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(189, 202);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ucThuoc2
            // 
            this.ucThuoc2.Location = new System.Drawing.Point(242, 0);
            this.ucThuoc2.Name = "ucThuoc2";
            this.ucThuoc2.Size = new System.Drawing.Size(1030, 621);
            this.ucThuoc2.TabIndex = 2;
            this.ucThuoc2.Load += new System.EventHandler(this.ucThuoc2_Load);
            // 
            // uC_Hienthi2
            // 
            this.uC_Hienthi2.BackColor = System.Drawing.Color.White;
            this.uC_Hienthi2.Location = new System.Drawing.Point(242, 0);
            this.uC_Hienthi2.Name = "uC_Hienthi2";
            this.uC_Hienthi2.Size = new System.Drawing.Size(1030, 621);
            this.uC_Hienthi2.TabIndex = 6;
            // 
            // frm_NhanVienQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 623);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.uC_Hienthi2);
            this.Controls.Add(this.ucThuoc2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhanVienQLKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NhanVienQLKho";
            this.Load += new System.EventHandler(this.frm_NhanVienQLKho_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buLogout;
        private Guna.UI2.WinForms.Guna2Button buThuoc;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private NguoiQL.UCThuoc ucThuoc2;
        private UC_Hienthi uC_Hienthi2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guilabelTenDN;
    }
}