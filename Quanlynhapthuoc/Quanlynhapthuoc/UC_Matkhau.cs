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

namespace Quanlynhapthuoc
{
    public partial class UC_Matkhau : UserControl
    {
        public UC_Matkhau()
        {
            InitializeComponent();
        }
        public void Hiengriv()
        {
            DataTable dt = new DataTable();
            dt = QLMK.MK();
            Danhsachmk.DataSource = dt;
        }
        public void Combox()
        {
            DataTable dt = new DataTable();
            dt = QLMK.Nguoiql();
            cbQL.DataSource = dt;
            cbQL.DisplayMember = "Ho_Ten";
            cbQL.ValueMember = "Ma_Nguoi_QL";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatk.Text = Danhsachmk.CurrentRow.Cells[0].Value.ToString();
            txtTendn.Text = Danhsachmk.CurrentRow.Cells[1].Value.ToString();
            txtMk.Text = Danhsachmk.CurrentRow.Cells[2].Value.ToString();
            cbLoai.Text = Danhsachmk.CurrentRow.Cells[3].Value.ToString();
            cbQL.SelectedValue = Danhsachmk.CurrentRow.Cells[4].Value.ToString();
        }

        private void UC_Matkhau_Load(object sender, EventArgs e)
        {
            cbLoai.Items.Add("Quản Trị Viên");
            cbLoai.Items.Add("Người Quản Lý Kho");
            Hiengriv();
            Combox();
        }

        private void buTang_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QLMK.MaMKLN();
            string a = dt.Rows[0][0].ToString();
            txtMatk.Text = "TK" + (int.Parse(a.Substring(a.Length - 2, 2)) + 1).ToString("000");
            txtTendn.Text = "";
            txtMk.Text = "";
            cbLoai.Text = "";
            cbQL.Text = "";
        }

        private void buThem_Click(object sender, EventArgs e)
        {
            Danhsachmk.DataSource=null;
            try
            {
                QLMK.Themmk(txtMatk.Text, txtTendn.Text, txtMk.Text, cbLoai.Text, cbQL.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng kiểm tra lại dữ liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
            Hiengriv();
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buSua_Click(object sender, EventArgs e)
        {
            Danhsachmk.DataSource = null;
            try
            {
                QLMK.Suamk(txtMatk.Text, txtTendn.Text, txtMk.Text, cbLoai.Text, cbQL.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng kiểm tra lại dữ liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Hiengriv();
        }

        private void buXoa_Click(object sender, EventArgs e)
        {

            DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == kq)
            {
                Danhsachmk.DataSource= null;
                QLMK.Xoamk(txtMatk.Text);
            }
            Hiengriv();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
