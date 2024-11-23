using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlynhapthuoc.DAO
{
    internal class QLMK
    {
        public static DataTable MK()
        {
            string sql = "select*from NguoiDung";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable MaMKLN()
        {
            string sql = " select top 1 MaTK from NguoiDung order by MaTK desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable Nguoiql()
        {
            string sql = "select*from Nguoi_QL_Kho";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static void Themmk(string ma,string ten,string mk,string loai,string nql)
        {
            string sql = "INSERT INTO NguoiDung(MaTK,TenDangnhap,Matkhau,LoaiTK,MaNguoiQL)VALUES ('"+ma+"', '"+ten+"','"+mk+"', '"+loai+"','"+nql+"');";
            KNCSDL.Thucthidulieu(sql);
        }
        public static void Suamk(string ma, string ten, string mk, string loai, string nql)
        {
            string sql = "update NguoiDung set TenDangnhap='"+ten+"',Matkhau='"+mk+"',LoaiTK='"+loai+"',MaNguoiQL='"+nql+"' where MaTK='"+ma+"'";
            KNCSDL.Thucthidulieu(sql);
        }
        public static void Xoamk(string ma)
        {
            string sql = "delete from NguoiDung where MaTK='"+ma+"'";
            KNCSDL.Thucthidulieu(sql);
        }
    }
}
