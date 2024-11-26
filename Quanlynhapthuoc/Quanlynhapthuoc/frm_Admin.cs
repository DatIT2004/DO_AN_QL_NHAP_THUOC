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
                uC_Hienthi1.Visible = true;
                guilabelTenDN.Text = frm_dangnhap.tendangnhap;
                 
            }//kiem tra user co hack vo admin ko neu co day ra trang dn
            if (frm_dangnhap.loaitk != "nguoiql")
            {

                frm_dangnhap ff = new frm_dangnhap();
                ff.Show();  

            }
        }

        private void buNhanvien_Click(object sender, EventArgs e)
        {
            
            ucNhanvien1.Visible = true;
            ucNhanvien1.BringToFront();
            

        }

        private void buThuoc_Click(object sender, EventArgs e)
        {
            
            ucThuoc1.Visible = true;
            ucThuoc1.BringToFront();
            
        }

        private void buNhaCap_Click(object sender, EventArgs e)
        {
            
            uC_NHACUNGCAP1.Visible = true;
            uC_NHACUNGCAP1.BringToFront();
           
        }

        private void buDoimk_Click(object sender, EventArgs e)
        {
            
            uC_Matkhau1.Visible = true;
            uC_Matkhau1.BringToFront();
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guilabelTenDN_Click(object sender, EventArgs e)
        {

        }

        private void uC_Hienthi1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Matkhau1_Load(object sender, EventArgs e)
        {

        }

        private void uC_NHACUNGCAP1_Load(object sender, EventArgs e)
        {

        }

        private void ucNhanvien1_Load(object sender, EventArgs e)
        {

        }

        private void ucThuoc1_Load(object sender, EventArgs e)
        {

        }
    }
}
