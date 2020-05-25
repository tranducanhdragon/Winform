using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 6;
            add(ref i);
            add(6);
            Console.WriteLine(i);
            Console.Read();
        }
        static void add(ref int x)
        {
            x = x * x;
        }
        static void add(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    class equal
    {
        public int x, y;
        public Boolean Boo()
        {
            return x == y;
        }
    }
}
