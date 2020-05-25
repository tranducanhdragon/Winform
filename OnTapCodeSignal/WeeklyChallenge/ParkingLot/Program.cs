using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = parkingCost("12:20", "14:54");
            Console.WriteLine(m);
            Console.Read();
        }
        static int parkingCost(string i, string o)
        {
            string[] si = i.Split(':');
            string[] so = o.Split(':');
            int hi = int.Parse(si[0]), mi = int.Parse(si[1]);
            int ho = int.Parse(so[0]), mo = int.Parse(so[1]);
            int tn = (ho - hi) * 60 + (mo - mi);
            int m = 0;
            if (tn % 10 != 0)
                tn += 10;
            for (int k = 0; k < tn; k+= 10)
            {
                if (k > 30)
                    m++;
                if (k > 120)
                    m++;

            }
            return m;
        }
    }
}
