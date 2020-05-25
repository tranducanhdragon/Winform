using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class PhongMayAccess : DatabaseAccess
    {
        public List<MayTinh> LayToanBoMayTinh()
        {
            List<MayTinh> dsMT = new List<MayTinh>();
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from MayTinh";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string MaMay = reader.GetString(0);
                string TinhTrang = reader.GetString(1);
                string TenDangNhap = reader.GetString(2);
                string SoGioOnline = reader.GetString(3);

                MayTinh mt = new MayTinh();
                mt.MaMay = MaMay+"";
                mt.TinhTrang = TinhTrang;
                mt.TenDangNhap = TenDangNhap;
                mt.SoGioOnline = SoGioOnline;

                dsMT.Add(mt);
            }
            reader.Close();
            return dsMT;
        }
        public bool TatMay(string ma)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update MayTinh set TinhTrang = 'Offline',TenDangNhap='',SoGioOnline='' where MaMay=@ma";
            comm.Connection = conn;
            comm.Parameters.Add("@ma", SqlDbType.NVarChar).Value = ma;

            return comm.ExecuteNonQuery() > 0;
        }
        public bool TatMayTuUser(string tenUser)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update MayTinh set TinhTrang = 'Offline',TenDangNhap='',SoGioOnline='' where TenDangNhap=@tenDangNhap";
            comm.Connection = conn;
            comm.Parameters.Add("@tenDangNhap", SqlDbType.NVarChar).Value = tenUser;

            return comm.ExecuteNonQuery() > 0;

        }
        public void UpDateGioChoi(string tenDangNhap, string sogio)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update MayTinh set SoGioOnline=@sogio, TinhTrang='Online' where TenDangNhap=@tenDangNhap";
            comm.Connection = conn;
            comm.Parameters.Add("@tenDangNhap", SqlDbType.NVarChar).Value = tenDangNhap;
            comm.Parameters.Add("@sogio", SqlDbType.NChar, 100).Value = sogio;
            comm.ExecuteNonQuery();
        }
        public string CheckEmpty()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CheckEmptyMay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add("@maEmpty", SqlDbType.NVarChar, 100);
            cmd.Parameters["@maEmpty"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string result = Convert.ToString(cmd.Parameters["@maEmpty"].SqlValue);
            if(result == "Null")
            {
                return null;
            }
            else
            {
                return result;
            }
        }
    }
}
