using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            int x = 0;
            int temp = 0;
            bool t;
            while (true)
            {
                s = Console.ReadLine();
                t = int.TryParse(s, out x);
                if(t == false)
                {
                    Console.WriteLine("{0} khong phai la so!", s);
                    temp++;
                }
                if(temp == 5)
                {
                    break;
                }
            }
            Console.Read();
        }
    }
}
