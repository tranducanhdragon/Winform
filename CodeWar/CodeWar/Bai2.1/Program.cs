using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + NumberOfZeroDigits(50));

        }
        static long NumberOfZeroDigits(long n)
        {
            long t = 0;
            long dem = 0;
            
            if (n < 5)
            {
                return 0;
            }
            long kc = 0, gan = 0;
            for (long i = 1; i <= n; i++)
            {
                PowerOf5(i,ref dem);
                if(dem != 0)
                {
                    kc++;
                    gan = dem;
                }
                if(gan != 0)
                {
                    if(gan >= 2)
                    {
                        kc += gan - 1;
                        t = t + kc ;
                    }
                    else
                    {
                        t = t + kc + gan - 1;
                    }
                    

                }
                if(gan == 0)
                {
                    t = t + kc;
                }
                gan = 0;
                 
            }

            return t;
         }



        static void PowerOf5(long n, ref long t)
        {
            t = 0;
            if (n == 0)
            {
                return ;
            }
                

            while (n != 1)
            {
                if (n % 5 != 0)
                {
                    return ;
                }   
                n = n / 5;
                t++;
            }
            return ;
        }
    }
}
