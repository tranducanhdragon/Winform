using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocThi3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "..****", "..**.*", "..**.*", "..**.*", "..****" };
            Console.WriteLine(" " + DigitalNumber(s));
            Console.Read();
        }
        static string DigitalNumber(string[] lightStatus)
        {
            int length = lightStatus.Length;
            int str_len = lightStatus[0].Length;
            string num = "";
            int t = 0;

            while (t != str_len)
            {
                string[] s = new string[5] ;

                for (int i = 0; i < length; i++)
                {
                    s[i] = lightStatus[i].Substring(t, 3);

                }
                num+= PhanTich(s);
                
                t += 3;
            }
            
            return num;
        }

        static string PhanTich(string[] chuoi)
        {
            string number = "";
            Mang m = new Mang(5, 3);
            for (int i = 0; i < 5; i++)
            {
                chuoi[i].ToArray();
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = chuoi[i][j];
                }
            }

            if (m[0, 0] == '*' && m[1, 1] == '.' && m[2, 1] == '.' && m[3, 1] == '.')
            {
                number = "0";
            }
            else if (m[0, 0] == '.' && m[0, 2] == '*' && m[1, 2] == '*' && m[2, 2] == '*' && m[3, 2] == '*' && m[4, 2] == '*')
            {
                number = "1";
            }
            else if (m[0, 0] == '*' && m[0, 1] == '*' && m[0, 2] == '*' && m[1, 0] == '.' && m[3, 0] == '*')
            {
                number = "2";
            }
            else if (m[1, 0] == '.' && m[2, 0] == '*')
            {
                number = "3";
            }
            else if (m[0, 1] == '.')
            {
                number = "4";
            }
            else if (m[1, 2] == '.' && m[3, 0] == '.')
            {
                number = "5";
            }
            else if (m[1, 2] == '.')
            {
                number = "6";
            }
            else if (m[2, 0] == '.')
            {
                number = "7";
            }
            else if (m[3, 0] == '*')
            {
                number = "8";
            }
            else
            {
                number = "9";
            }

            return number;

        }
    }
    class Mang
    {

        private char[,] matrix = new char[5, 3];
        private int hang;
        private int cot;

        public Mang(int row, int column)
        {
            hang = row;
            cot = column;
        }
        public char this[int index1, int index2]
        {
            get
            {
                if (index1 < 0 || index1 > 5 || index2 < 0 || index2 > 3)
                    throw new IndexOutOfRangeException("Vuot qua chi so mang");
                else
                    return matrix[index1, index2];
            }
            set
            {
                 matrix[index1, index2] = value;
            }
        }
        public int Hang
        {
            get { return hang; }
            set { hang = value; }
        }
        public int Cot
        {
            get { return cot; }
            set { cot = value; }
        }
    }
}
