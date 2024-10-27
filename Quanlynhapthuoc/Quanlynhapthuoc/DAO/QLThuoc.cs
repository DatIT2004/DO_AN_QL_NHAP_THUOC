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
    }
}
