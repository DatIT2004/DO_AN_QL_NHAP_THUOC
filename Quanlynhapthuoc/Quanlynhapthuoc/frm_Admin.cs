using Quanlynhapthuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhapthuoc.NguoiQL;

namespace Quanlynhapthuoc
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void buLogout_Click(object sender, EventArgs e)
        {
            frm_dangnhap f1 = new frm_dangnhap();
            f1.Show();
            this.Hide();
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            if(frm_dangnhap.loaitk=="nguoiql")
            {
                guilabelTenDN.Text = frm_dangnhap.tendangnhap;
                ucNhanvien1.Visible = false;
                ucThuoc1.Visible = false;
            }
        }

        private void buNhanvien_Click(object sender, EventArgs e)
        {
            
            ucNhanvien1.Visible = true;
            ucNhanvien1.BringToFront();
            ucThuoc1.Visible = false;
        }

        private void buThuoc_Click(object sender, EventArgs e)
        {
            
            ucThuoc1.Visible = true;
            ucThuoc1.BringToFront();
            ucNhanvien1.Visible = false;
        }

        private void buNhaCap_Click(object sender, EventArgs e)
        {

        }

        private void buDoimk_Click(object sender, EventArgs e)
        {

        }
    }
}
