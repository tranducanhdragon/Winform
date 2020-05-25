using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ViDuRegex
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string s6 = "m";
            bool match = Regex.IsMatch(s6, "m$");
            Console.WriteLine("match = " + match);
            Console.ReadKey();
        }
    }
}
