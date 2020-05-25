using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine md1 = new Medicine();
            md1.Accept();
            md1.Print();
            Console.ReadKey();
        }
    }
}
