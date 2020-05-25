using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL // lop nay de kiem tra nghiep vu roi ra lenh lay du lieu
    {
        TaiKhoanAccess tka = new TaiKhoanAccess();
        public List<TaiKhoan> LayToanBoTaiKhoan()
        {
            return tka.LayToanBoTaiKhoan();
        }
        public bool XoaTaiKhoan(string TenDangNhap)
        {
            return tka.XoaTaiKhoan(TenDangNhap);
        }
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            // kiểm tra điều kiện
            if(tk.TenDangNhap != "" && tk.MatKhau != "")
            {
                return tka.ThemTaiKhoan(tk);
            }
            else
            {
                return false;
            }
            
        }
        public bool ThemMayChoTK(TaiKhoan tk)
        {
            return tka.ThemMayChoTK(tk);
        }
        public bool SuaThongTinTaiKhoan(string ten,string mk,int sotien)
        {
            return tka.SuaThongTinTaiKhoan(ten, mk, sotien);
        }
        public bool UpdateTienSauKhiTatMay(string ten, int sotien)
        {
            return tka.UpdateTienSauKhiTatMay(ten, sotien);
        }
        public bool NapThemTien(string ten,int sotien)
        {
            return tka.NapThemTien(ten, sotien);
        }
    }
}
