using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapVeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Diem a = new Diem(1, 2);
            Diem b = new Diem(3, 4);
            Diem c = new Diem(2, 5);
            Diem d = new Diem(4, 6);
            Diem e = new Diem(5, 9);
            DoanThang l = new DoanThang(a, b);

            List<HinhHoc> ds = new List<HinhHoc>();
            HinhHoc tg = new TamGiac(a, b, c);
            ds.Add(tg);
            HinhHoc tg2 = new TamGiac(a, b, d);
            ds.Add(tg2);
            HinhHoc tg3 = new TamGiac(a, d, e);
            ds.Add(tg3);
            ds.Sort();
            foreach(HinhHoc i in ds)
            {
                i.HienThi();
            }
            Console.Read();
        }
    }
}
