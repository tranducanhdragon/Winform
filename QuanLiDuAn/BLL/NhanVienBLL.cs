using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nva = new NhanVienAccess();
        public List<NhanVien> LayToanBoNhanVien()
        {
            return nva.LayToanBoNhanVien();
        }
        public bool SuaNhanVien(string ma, string ten, string quequan, string chucvu, int hesoluong, string hinhanh)
        {
            return nva.SuaNhanVien(ma, ten, quequan, hesoluong, hinhanh, chucvu);
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            return nva.ThemNhanVien(nv);
        }
        public bool XoaNhanVien(string MaNV)
        {
            return nva.XoaNhanVien(MaNV);
        }
    }
}
