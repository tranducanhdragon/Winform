using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = digitDistanceNumber(100001111);
            Console.WriteLine(s);
            Console.Read();
        }
        static int digitDistanceNumber(int n)
        {
            int i = 0;
            int m = 1;
            while (n >= 10)
            {
                int t = Math.Abs(n % 10 - (n / 10) % 10) * m;
                i += t;
                m *= 10;
                n /= 10;
            }

            return i ;
        }

    }
}
