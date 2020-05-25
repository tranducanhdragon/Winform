using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int tong = 0;
            ConsoleKeyInfo k;
            int so_am = 0;
            int so_duong = 0;
            while (true)
            {
                s = Console.ReadLine();
                k = Console.ReadKey();
                if (k.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("s = " + s);
                    if(int.Parse(s) < 0)
                    {
                        so_am++;
                    }
                    else
                    {
                        so_duong++;
                    }
                    tong = tong + int.Parse(s);
                }
            }
            
            Console.WriteLine("tong = "+tong);
            Console.WriteLine("Co {0} so am va {1} so duong ", so_am, so_duong);
            Console.Read();
        }    
    }
}
