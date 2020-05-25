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
    public class TaiKhoanAccess : DatabaseAccess
    {
        public List<TaiKhoan> LayToanBoTaiKhoan()
        {
            List<TaiKhoan> dsTK = new List<TaiKhoan>();

            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from TAIKHOAN";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string TenDangNhap = reader.GetString(0);
                string MatKhau = reader.GetString(1);
                DateTime NgayTao = reader.GetDateTime(2);
                int SoTien = reader.GetInt32(3);

                TaiKhoan tk = new TaiKhoan();
                tk.TenDangNhap = TenDangNhap;
                tk.MatKhau = MatKhau;
                tk.NgayTao = NgayTao;
                tk.SoTien = SoTien;
                dsTK.Add(tk);
            }

            reader.Close();

            return dsTK;
        }

        public bool XoaTaiKhoan(string TenDangNhap)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from TAIKHOAN where TenDangNhap = @tendangnhap";
            command.Connection = conn;
            command.Parameters.Add("@tendangnhap", SqlDbType.NChar).Value = TenDangNhap;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
            
        }

        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            PhongMayAccess pm = new PhongMayAccess();
            if(pm.CheckEmpty() != null)
            {
                //Thêm tài khoản
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into TAIKHOAN(TenDangNhap,MatKhau,SoTien) values(@tendangnhap,@matkhau,@sotien)";

                command.Connection = conn;

                command.Parameters.Add("@tendangnhap", SqlDbType.NChar).Value = tk.TenDangNhap;
                command.Parameters.Add("@matkhau", SqlDbType.NChar).Value = tk.MatKhau;
                command.Parameters.Add("@sotien", SqlDbType.Int).Value = tk.SoTien;

                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            else
            {
                return false;
            }
        }
        public bool ThemMayChoTK(TaiKhoan tk)
        {
            //Thêm máy cho tài khoản này
            PhongMayAccess pm = new PhongMayAccess();
            if (pm.CheckEmpty() != null)
            {
                OpenConnection();
                SqlCommand cmdSetUserInMay = new SqlCommand("SetUserInMay", conn);
                cmdSetUserInMay.CommandType = CommandType.StoredProcedure;

                cmdSetUserInMay.Parameters.Add("@maMay", SqlDbType.NVarChar, 100).Value = pm.CheckEmpty();
                cmdSetUserInMay.Parameters.Add("@tenUser", SqlDbType.NVarChar, 200).Value = tk.TenDangNhap;
                cmdSetUserInMay.Parameters.Add("@tinhTrang", SqlDbType.NVarChar, 100).Value = "Online";
                cmdSetUserInMay.Parameters.Add("@sogio", SqlDbType.NChar, 100).Value = tk.SoTien / 5000;

                cmdSetUserInMay.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SuaThongTinTaiKhoan(string ten,string mk,int SoTien)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update TAIKHOAN set MatKhau=@matkhau,SoTien=@sotien where TenDangNhap = @ten";
            comm.Connection = conn;
            comm.Parameters.Add("@matkhau", SqlDbType.NChar).Value = mk;
            comm.Parameters.Add("@sotien", SqlDbType.Int).Value = SoTien;
            comm.Parameters.Add("@ten", SqlDbType.NChar).Value = ten;

            return comm.ExecuteNonQuery() > 0;
        }
        public bool UpdateTienSauKhiTatMay(string ten, int sotien)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update TAIKHOAN set SoTien=@sotien where TenDangNhap = @ten";
            comm.Connection = conn;
            comm.Parameters.Add("@sotien", SqlDbType.Int).Value = sotien;
            comm.Parameters.Add("@ten", SqlDbType.NChar).Value = ten;

            return comm.ExecuteNonQuery() > 0;
        }

        public bool NapThemTien(string tenDangNhap,int SoTien)
        {
            OpenConnection();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update TAIKHOAN set SoTien = @tien where TenDangNhap = @ten";
            comm.Connection = conn;
            comm.Parameters.Add("@tien", SqlDbType.Int).Value = SoTien;
            comm.Parameters.Add("@ten", SqlDbType.NChar).Value = tenDangNhap;
            return comm.ExecuteNonQuery() > 0;
        }
    }
}
