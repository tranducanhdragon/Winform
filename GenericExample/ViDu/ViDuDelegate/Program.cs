using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDuDelegate
{
    delegate int NumberChanger(int n);
    class Program
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MulNum(int p)
        {
            num *= p;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);

            nc1(15);
            nc2(20);

            Console.WriteLine(" Value of GetNum: " + GetNum());
            Console.ReadKey();
        }
    }
}
