using Quanlynhapthuoc.NguoiQL;
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
    public partial class frm_NhanVienQLKho : Form
    {
        public frm_NhanVienQLKho()
        {
            InitializeComponent();
        }
        private void frm_NhanVienQLKho_Load(object sender, EventArgs e)
        {
            if (frm_dangnhap.loaitk == "nhanvien")
            {
                uC_Hienthi2.Visible = true;
                guilabelTenDN.Text = frm_dangnhap.tendangnhap;
            }
        }

        private void guilabelTenDN_Click(object sender, EventArgs e)
        {

        }

        private void buLogout_Click_1(object sender, EventArgs e)
        {
            frm_dangnhap f = new frm_dangnhap();
            f.Show();
            this.Hide();
        }

        private void buThuoc_Click(object sender, EventArgs e)
        {
            ucThuoc2.Visible = true;
            ucThuoc2.BringToFront();
        }

        private void ucThuoc2_Load(object sender, EventArgs e)
        {

        }
    }
}
