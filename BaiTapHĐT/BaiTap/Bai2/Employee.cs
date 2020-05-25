using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Employee
    {
        protected string ma_nv;
        protected string ho_ten;
        protected string so_hd;
        protected int ngay_vao;

        public Employee(string manv, string hoten, string sohd, int ngay)
        {
            ma_nv = manv;
            ho_ten = hoten;
            so_hd = sohd;
            ngay_vao = ngay;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            ma_nv = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten nhan vien: ");
            ho_ten = Console.ReadLine();
            Console.WriteLine("Nhap so hop dong: ");
            so_hd = Console.ReadLine();
            Console.WriteLine("Nhap ngay vao: ");
            ngay_vao = Int32.Parse(Console.ReadLine());
        }
        public virtual void TaoHD()
        {
            so_hd = "HD" + ma_nv + ngay_vao.ToString();
        }
    }
}
