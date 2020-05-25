using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so sinh vien: ");
            int n = Int32.Parse(Console.ReadLine());
            List<SinhVien> ds = new List<SinhVien>();
            for(int i = 0;i<n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.Nhap();
                ds.Add(sv);
            }
            ds.Sort(new SapXepDiem());
            ds.Sort(new SapXepTen());
            foreach(SinhVien sv in ds){
                sv.Xuat();
            }
            Console.ReadKey();
        }
    }


}
