using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> ds_SinhVien = new List<SinhVien>(5);
            for(int i = 0; i<5; i++)
            {
                SinhVien sv = new SinhVien();
                sv.Nhap();
                ds_SinhVien.Add(sv);
            }
            /* lenh foreach chi truy xuat den phan tu trong mang, ko thay doi gtri 
               cua phan tu do*/
            foreach (SinhVien i in ds_SinhVien)
            {
                foreach(string st in i.GetTen().Split(' '))
                {
                    if(st == "Nguyen")
                    {
                        Console.WriteLine("Sinh vien co ho Nguyen la: " + i.GetTen());
                    }
                }
            }

            Console.Read();
        }
    }
    class SinhVien
    {
        protected string ho_ten;
        public SinhVien(){
            ho_ten = "NULL";
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten sinh vien: ");
            ho_ten = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Sinh vien: {0}", ho_ten);
        }
        public string GetTen()
        {
            return ho_ten;
        }
    }
}
