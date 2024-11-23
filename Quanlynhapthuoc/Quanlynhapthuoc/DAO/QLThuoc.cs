using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Quanlynhapthuoc.DAO
{
    internal class QLThuoc
    {
        public static DataTable TTDangnhap(string tendn,string mk)
        {
            string sql = "select*from NguoiDung where TenDangnhap='"+tendn+"' and Matkhau='"+mk+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable Thuoc()
        {
            string sql = "select*from Thuoc";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable MaThuocLN()
        {
            string sql = " select top 1 Ma_Thuoc from Thuoc order by Ma_Thuoc desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable HienthiNCC()
        {
            string sql = " select*from Nha_Cung_Cap";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable HienthiLoaiThuoc()
        {
            string sql = "select*from Loai_Thuoc";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable HienthiLoaiNSX()
        {
            string sql = "select*from Hang_SX";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static void Themthuoc(string ma,string ten,string ncc,string loai,string cd,string nsx)
        {
            string sql = "INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('"+ma+"', N'"+ten+"', '"+ncc+"', '"+loai+"', N'"+cd+"', '"+nsx+"');";
            KNCSDL.Thucthidulieu(sql);
        }
        public static void Suathuoc(string ma, string ten, string ncc, string loai, string cd, string nsx)
        {
            string sql = "update Thuoc set Ten_Thuoc='"+ten+"',Ma_Nha_Cung_Cap='"+ncc+"',Ma_Loai_Thuoc='"+loai+"',Cong_Dung='"+cd+"',Ma_Hang_SX='"+nsx+"'where Ma_Thuoc='"+ma+"'";
            KNCSDL.Thucthidulieu(sql);
        }
        public static void Xoathuoc(string ma)
        {
            string sql = "delete from Thuoc where Ma_Thuoc='"+ma+"'";
            KNCSDL.Thucthidulieu(sql);
        }
    }
}
