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

namespace Quanlynhapthuoc.NguoiQL
{
    public partial class UCThuoc : UserControl
    {
        public UCThuoc()
        {
            InitializeComponent();
        }
        public void HiencbNcc()
        {
            DataTable dt = new DataTable();
            dt = QLThuoc.HienthiNCC();
            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "Ten_Nha_Cung_Cap";
            cbNCC.ValueMember = "Ma_Nha_Cung_Cap";
        }
        public void HiencbLoai()
        {
            DataTable dt = new DataTable();
            dt = QLThuoc.HienthiLoaiThuoc();
            cbLoai.DataSource = dt;
            cbLoai.DisplayMember = "Ten_Loai_Thuoc";
            cbLoai.ValueMember = "Ma_Loai_Thuoc";
        }
        public void HiencbNSX()
        {
            DataTable dt = new DataTable();
            dt = QLThuoc.HienthiLoaiNSX();
            cbNSX.DataSource = dt;
            cbNSX.DisplayMember = "Ten_Hang";
            cbNSX.ValueMember = "Ma_Hang_SX";
        }
        public void List()
        {
            DataTable dt = new DataTable();
            dt = QLThuoc.Thuoc();
            dtgvDanhsachthuoc.DataSource = dt;
        }
        private void UCThuoc_Load(object sender, EventArgs e)
        {
            List();
            HiencbNcc();
            HiencbLoai();
            HiencbNSX();
            if(frm_dangnhap.loaitk == "nhanvien")
            {
                buXoathuoc.Enabled = false;
                buSuathuoc.Enabled = false;
            }
            
        }


       

        private void dtgvDanhsachthuoc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThuoc.Text = dtgvDanhsachthuoc.CurrentRow.Cells[0].Value.ToString();
            txtTenthuoc.Text = dtgvDanhsachthuoc.CurrentRow.Cells[1].Value.ToString();
            cbNCC.SelectedValue = dtgvDanhsachthuoc.CurrentRow.Cells[2].Value.ToString();
            cbLoai.SelectedValue = dtgvDanhsachthuoc.CurrentRow.Cells[3].Value.ToString();
            txtCongdung.Text = dtgvDanhsachthuoc.CurrentRow.Cells[4].Value.ToString();
            cbNSX.SelectedValue = dtgvDanhsachthuoc.CurrentRow.Cells[5].Value.ToString();
        }

        private void buXoathuoc_Click(object sender, EventArgs e)
        {
            
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==kq)
            {
                dtgvDanhsachthuoc.DataSource = null;
                QLThuoc.Xoathuoc(txtMaThuoc.Text);
            }
            List();

        }

        private void buTang_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QLThuoc.MaThuocLN();
            string a = dt.Rows[0][0].ToString();
            txtMaThuoc.Text = "TH" + (int.Parse(a.Substring(a.Length - 2, 2)) + 1).ToString("000");
            txtCongdung.Text = "";
            txtTenthuoc.Text = "";
            cbLoai.Text = "";
            cbNCC.Text = "";
            cbNSX.Text = "";
        }

        private void buThemthuoc_Click(object sender, EventArgs e)
        {
            dtgvDanhsachthuoc.DataSource = null;
            try
            {
                QLThuoc.Themthuoc(txtMaThuoc.Text, txtTenthuoc.Text, cbNCC.SelectedValue.ToString(), cbLoai.SelectedValue.ToString(), txtCongdung.Text, cbNSX.SelectedValue.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng kiểm tra lại dữ liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            List();
        }

        private void buSuathuoc_Click(object sender, EventArgs e)
        {
            dtgvDanhsachthuoc.DataSource = null;
            try
            {
                QLThuoc.Suathuoc(txtMaThuoc.Text, txtTenthuoc.Text, cbNCC.SelectedValue.ToString(), cbLoai.SelectedValue.ToString(), txtCongdung.Text, cbNSX.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng kiểm tra lại dữ liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            List();
        }
    }
}
