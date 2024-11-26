using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlynhapthuoc.DAO
{
    internal class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void Moketnoi()
        {
            try
            {
                string sqlcon = @"Data Source=DESKTOP-9TCL0NI\SQLEXPRESS;Initial Catalog=QL_NHAP_THUOC;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if(cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Kết nối không thành công!");
            }
        }
        public static void Dongketnoi()
        {

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public static DataTable Docdulieu(string sql)
        {
            Moketnoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Dongketnoi();
            return dt;
        }
        public static void Thucthidulieu(string sql)
        {
            Moketnoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            Dongketnoi();
        }
    }
}
