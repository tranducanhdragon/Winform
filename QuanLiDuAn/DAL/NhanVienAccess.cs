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
    public class NhanVienAccess:DatabaseAccess
    {
        public List<NhanVien> LayToanBoNhanVien()
        {
            List<NhanVien> dsNV = new List<NhanVien>();

            
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from NhanVien";
            comm.Connection = conn;
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string MaNV = reader.GetString(0);
                string TenNV = reader.GetString(1);
                string QueQuan = reader.GetString(2);
                DateTime NgaySinh = reader.GetDateTime(3);
                DateTime NgayVaoLam = reader.GetDateTime(4);
                int HeSoLuong = reader.GetInt32(5);
                string HinhAnh = reader.GetString(6);
                string ChucVu = reader.GetString(7);

                NhanVien nv = new NhanVien();
                nv.MaNV = MaNV;
                nv.TenNV = TenNV;
                nv.QueQuan = QueQuan;
                nv.NgaySinh = NgaySinh;
                nv.NgayVaoLam = NgayVaoLam;
                nv.HeSoLuong = HeSoLuong;
                nv.HinhAnh = HinhAnh;
                nv.ChucVu = ChucVu;
            
                dsNV.Add(nv);
            }
            reader.Close();


            return dsNV;
        }
        
        public bool SuaNhanVien(string ma,string ten,string quequan,int hesoluong,string hinhanh,string chucvu)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaThongTinNhanVien";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = ma;
            command.Parameters.Add("@ten", SqlDbType.NChar).Value = ten;
            command.Parameters.Add("@quequan", SqlDbType.NChar).Value = quequan;
            command.Parameters.Add("@hesoluong", SqlDbType.Int).Value = hesoluong;
            command.Parameters.Add("@hinhanh", SqlDbType.NChar).Value = hinhanh;
            command.Parameters.Add("@chucvu", SqlDbType.NChar).Value = chucvu;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }

        public bool ThemNhanVien (NhanVien nv)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into NhanVien(MaNV,TenNV,QueQuan,NgaySinh,HeSoLuong,HinhAnh,ChucVu) values(@ma,@ten,@quequan,@NgaySinh,@HeSoLuong,@HinhAnh,@ChucVu)";

            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = nv.MaNV;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nv.TenNV;
            command.Parameters.Add("@quequan", SqlDbType.NChar).Value = nv.QueQuan;
            command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
            command.Parameters.Add("@HeSoLuong", SqlDbType.Int).Value = nv.HeSoLuong;
            command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = nv.HinhAnh;
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;

            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }

        public bool XoaNhanVien(string MaNV)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from NhanVien where MaNV = @ma";
            comm.Connection = conn;
            comm.Parameters.Add("@ma", SqlDbType.NChar).Value = MaNV;
            int kq = comm.ExecuteNonQuery();
            return kq > 0;
        }

    }
}
