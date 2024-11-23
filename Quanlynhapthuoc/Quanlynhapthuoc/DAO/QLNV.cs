using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlynhapthuoc.DAO
{
    internal class QLNV
    {
        public static DataTable Nhanvien()
        {
            string sql = "select*from Nguoi_QL_Kho";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
        public static DataTable MaNVLN()
        {
            string sql = "select top 1 Ma_Nguoi_QL from Nguoi_QL_Kho order by Ma_Nguoi_QL desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.Docdulieu(sql);
            return dt;
        }
       
    }
}
