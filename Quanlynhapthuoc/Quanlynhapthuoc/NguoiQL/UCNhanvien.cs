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
    public partial class UCNhanvien : UserControl
    {
        public UCNhanvien()
        {
            InitializeComponent();
        }
        public void Hienthigriv()
        {
            DataTable dt = new DataTable();
            dt = QLNV.Nhanvien();
            dtgvDanhsach.DataSource = dt;
        }
        private void UCNhanvien_Load(object sender, EventArgs e)
        {
            Hienthigriv();
        }

        private void dtgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvDanhsach.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dtgvDanhsach.CurrentRow.Cells[1].Value.ToString();
            dtNgaysinhNV.Text = dtgvDanhsach.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dtgvDanhsach.CurrentRow.Cells[3].Value.ToString();
        }

        private void buTang_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QLNV.MaNVLN();
            string a = dt.Rows[0][0].ToString();
            txtMaNV.Text = "QL" + (int.Parse(a.Substring(a.Length - 2, 2)) + 1).ToString("000");
            txtTenNV.Text = "";
            dtNgaysinhNV.Text = "";
            txtSdt.Text = "";
        }

        private void buThemNV_Click(object sender, EventArgs e)
        {
           
        }
    }
}
