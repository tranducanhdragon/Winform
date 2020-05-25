using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            for(int i=1; i<=x/2; i++)
            {
                if(x % i == 0)
                {
                    Console.WriteLine("Uoc cua {0} la {1} ",x, i);
                }
            }
            Console.Read();
        }
    }
}
