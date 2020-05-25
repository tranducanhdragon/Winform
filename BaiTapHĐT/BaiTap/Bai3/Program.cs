using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            MaTran mt = new MaTran(2, 3);
            mt[0, 0] = 1;
            mt[0, 1] = 2;
            mt[0, 2] = 3;
            mt[1, 0] = 4;
            mt[1, 1] = 5;
            mt[1, 2] = 6;
            MaTran mt1 = new MaTran(3, 2);
            mt1[0, 0] = 1;
            mt1[0, 1] = 2;
            mt1[1, 0] = 3;
            mt1[1, 1] = 4;
            mt1[2, 0] = 5;
            mt1[2, 1] = 6;
            MaTran mt3 = new MaTran(2, 2);
            mt3 = mt * mt1;
            mt3.HienThi();
            Console.Read();
        }
    }
}
