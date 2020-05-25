using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDuDelegate2
{
    class Program
    {
        public delegate void TinhToan(int a, int b);
        static void GetCong(int a, int b)
        {
            Console.WriteLine(" "+ (a + b));
        }
        static void GetNhan(int a, int b)
        {
            Console.WriteLine(" "+ (a * b));
        }
        static void Main(string[] args)
        {
            TinhToan tt;
            TinhToan ttcong = new TinhToan(GetCong);
            TinhToan ttnhan = new TinhToan(GetNhan);

            tt = ttcong;
            tt(1, 2);
            tt = ttnhan;
            tt(1, 2);

            Console.ReadKey();
        }
    }
}
