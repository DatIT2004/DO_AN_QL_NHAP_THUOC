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
using Quanlynhapthuoc.DAO;

namespace Quanlynhapthuoc
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string loaitk;
        public static string tendangnhap;
        private void buDangnhap_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = QLThuoc.TTDangnhap(txtTen.Text,txtMatkhau.Text);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!. Vui lòng nhập lại!", "Thông  báo!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                loaitk = dt.Rows[0][3].ToString();
                tendangnhap = dt.Rows[0][1].ToString();
                if (dt.Rows[0][3].ToString()=="nguoiql")
                {
                    frm_Admin f2 = new frm_Admin();
                    f2.Show();
                    txtTen.Text = "";
                    txtMatkhau.Text = "";
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar =!txtMatkhau.UseSystemPasswordChar;
            txtMatkhau.PasswordChar = (char)0;
        }
    }
}
