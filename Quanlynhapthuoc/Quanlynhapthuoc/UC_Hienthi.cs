using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhapthuoc
{
    public partial class UC_Hienthi : UserControl
    {
        public UC_Hienthi()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gio.Text = DateTime.Now.ToString("HH:mm");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Hienthi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            guna2DateTimePicker1.Value = DateTime.Now;
        }
    }
}
