using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee p1 = new PartTimeEmployee("123", "Duc Anh", "NULL", 10);
            p1.TaoHD();
            Console.ReadKey();
        }
    }
}
