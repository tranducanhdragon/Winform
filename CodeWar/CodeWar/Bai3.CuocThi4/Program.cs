using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai3.CuocThi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" " + SumOfSquare(5000000));
            Console.ReadKey();

        }

        static int SumOfSquare(int n)
        {
            double res = n;
            int dem = 0;

            for (int i = 0; i < Math.Sqrt(n / 3); i++)
            {
                for (int j = i + 1; j < Math.Sqrt(n / 2); j++)
                {
                    double t = n - i * i - j * j;
                    if (t == ((int)Math.Sqrt(t) * (int)Math.Sqrt(t)) && (int)Math.Sqrt(t) > j)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

    }
}
