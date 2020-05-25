using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System.Numerics;*/
namespace Bai2.CuocThi4
{
    class Program
    {
        static void Main(string[] args)
        {

            //             // convert to binary
            //             string binary = IntToString(42, new char[] { '0', '1' });
            // 
            //             // convert to hexadecimal
            //             string hex = IntToString(42,
            //                 new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            //                          'A', 'B', 'C', 'D', 'E', 'F'});
            // 
            //             // convert to hexavigesimal (base 26, A-Z)
            //             string hexavigesimal = IntToString(26,
            //                 Enumerable.Range('a', 26).Select(x => (char)x).ToArray());
            // 
            //             // convert to sexagesimal
            //             string xx = IntToString(42,
            //                 new char[] { '0','1','2','3','4','5','6','7','8','9',
            //             'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            //             'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x'});


            string s = "57175776";
            Console.WriteLine(" " + ConvertString(s));



            //             BigInteger a = new BigInteger("7485811234789769785674585645782934718975289034752903847589347565960786");
            //             BigInteger b = new BigInteger("1");
            //             Console.WriteLine("" + a.Add(b));
            Console.Read();
        }
        public static string IntToString(System.Numerics.BigInteger value, char[] baseChars)
        {
            string result = string.Empty;
            System.Numerics.BigInteger targetBase = baseChars.Length - 1;

            do
            {
                int t = (int)(value % targetBase);
                result = baseChars[t] + result;
                value = value / targetBase;
            }
            while (value > 0);

            return result;
        }
        public static System.Numerics.BigInteger StringToInt(Dictionary<System.Numerics.BigInteger, char> value, Dictionary<int, char> baseNumbs)

        {
            System.Numerics.BigInteger result = 0;
            int targetBase = baseNumbs.Count;
            Int32 count = 0;
            do
            {
                System.Numerics.BigInteger mykey = baseNumbs.FirstOrDefault(x => x.Value == value[count]).Key;
                result += mykey * System.Numerics.BigInteger.Pow(targetBase, count);
                count++;
            }
            while (count < value.Count);

            return result;
        }

        /// <summary>
        /// An optimized method using an array as buffer instead of 
        /// string concatenation. This is faster for return values having 
        /// a length > 1.
        /// </summary>
        public static string IntToStringFast(long value, char[] baseChars)
        {
            // 32 is the worst cast buffer size for base 2 and int.MaxValue
            int i = 32;
            char[] buffer = new char[i];
            int targetBase = baseChars.Length;

            do
            {
                buffer[--i] = baseChars[value % targetBase];
                value = value / targetBase;
            }
            while (value > 0);

            char[] result = new char[32 - i];
            Array.Copy(buffer, i, result, 0, 32 - i);

            return new string(result);
        }

        static string ConvertString(string s)
        {
            var charsToRemove = new string[] { "," };
            foreach (var c in charsToRemove)
            {
                s = s.Replace(c, string.Empty);
            }
            string hexavigesimal = string.Empty;
            System.Numerics.BigInteger numb = 0;
            char[] basechar = "0abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Dictionary<int, char> basenumb = new Dictionary<int, char>();
            for (int i = 1; i <= 26; i++)
            {
                basenumb[i] = basechar[i];
            }
            if (System.Numerics.BigInteger.TryParse(s, out numb) && numb > 0)
            {
                hexavigesimal = IntToString(numb, basechar);
                return hexavigesimal;
            }
            else
            {
                Dictionary<System.Numerics.BigInteger, char> arr_reverse = new Dictionary<System.Numerics.BigInteger, char>();
                System.Numerics.BigInteger index = 0;
                List<char> lt = s.ToList();
                lt.Reverse();
                lt.ForEach(x =>
                {
                    arr_reverse.Add(index, x);
                    index++;
                });

                hexavigesimal = StringToInt(arr_reverse, basenumb).ToString();
            }


            var hexavigesimal_after = new StringBuilder();
            int count = 0;
            foreach (var c in hexavigesimal.Reverse())
            {
                hexavigesimal_after.Append(c);
                if ((++count % 3) == 0)
                {
                    hexavigesimal_after.Append(',');
                }
            }
            string last_hex = hexavigesimal_after.ToString();
            string last_hex2 = hexavigesimal_after.ToString();
            if (last_hex[last_hex.Length - 1] == ',')
            {
                last_hex2 = last_hex.Remove(last_hex.Length - 1);
            }
            char[] last = last_hex2.Reverse().ToArray();

            return new string(last);
        }
    }
    class BigInteger
    {
        //initial variables
        private string BigValue;
        public int Length;

        //Constructor
        public BigInteger(string value)
        {
            BigValue = value;
            Length = value.Length;
        }

        //String value
        public override string ToString()
        {
            return BigValue;
        }

        //Comparison
        private int CompareTo(BigInteger BigIntegerTwo) //returns -1 if less than argument, 0 if equal, and 1 if greater than
        {
            int CharDifference = Length - BigIntegerTwo.Length;
            if (CharDifference < 0)
            {
                return -1;
            }
            else if (CharDifference > 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    int ThisValue = int.Parse(BigValue.Substring(i, 1));
                    int ArgValue = int.Parse(BigIntegerTwo.BigValue.Substring(i, 1));
                    if (ThisValue > ArgValue)
                    {
                        return 1;
                    }
                    else if (ThisValue < ArgValue)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }

        //Equals
        public bool Equals(BigInteger BigIntegerTwo)
        {
            if (this.CompareTo(BigIntegerTwo) == 0)
            {
                return true;
            }

            return false;
        }

        //Less Than
        public bool LessThan(BigInteger BigIntegerTwo)
        {
            if (this.CompareTo(BigIntegerTwo) == -1)
            {
                return true;
            }

            return false;
        }

        //Greater Than
        public bool GreaterThan(BigInteger BigIntegerTwo)
        {
            if (this.CompareTo(BigIntegerTwo) == 1)
            {
                return true;
            }

            return false;
        }

        //Addition
        public BigInteger Add(BigInteger BigIntegerTwo)
        {
            string SumString = "";

            int CharDifference = Length - BigIntegerTwo.Length;

            int Remainder = 0;

            if (CharDifference == 0)
            {
                for (int i = Length - 1; i >= 0; i--)
                {
                    int Top = int.Parse(BigValue.Substring(i, 1)) + Remainder;
                    int Bottom = int.Parse((BigIntegerTwo.ToString()).Substring(i, 1));
                    int Sum = (Top + Bottom);

                    if ((Sum >= 10) && (i != 0))
                    {
                        Sum -= 10;
                        Remainder = 1;
                    }
                    else
                    {
                        Remainder = 0;
                    }
                    SumString = Sum.ToString() + SumString;
                }
            }
            else
            {
                if (CharDifference < 0)
                {
                    string Pref = BigIntegerTwo.ToString().Substring(0, CharDifference * -1);
                    string Suff = BigIntegerTwo.ToString().Substring((CharDifference * -1));

                    for (int i = Suff.Length - 1; i >= 0; i--)
                    {
                        int Top = int.Parse(BigValue.Substring(i, 1)) + Remainder;
                        int Bottom = int.Parse(Suff.Substring(i, 1));
                        int Sum = (Top + Bottom);

                        if ((Sum >= 10))
                        {
                            Sum -= 10;
                            Remainder = 1;
                        }
                        else
                        {
                            Remainder = 0;
                        }
                        SumString = Sum.ToString() + SumString;
                    }

                    for (int i = Pref.Length - 1; i >= 0; i--)
                    {
                        int Top = int.Parse(Pref.Substring(i, 1)) + Remainder;
                        if ((Top >= 10) && (i != 0))
                        {
                            Top -= 10;
                            Remainder = 1;
                        }
                        else
                        {
                            Remainder = 0;
                        }
                        SumString = Top.ToString() + SumString;
                    }
                }
                else
                {
                    string Pref = BigValue.Substring(0, CharDifference);
                    string Suff = BigValue.Substring((CharDifference));

                    for (int i = Suff.Length - 1; i >= 0; i--)
                    {
                        int Top = int.Parse(Suff.Substring(i, 1)) + Remainder;
                        int Bottom = int.Parse((BigIntegerTwo.ToString()).Substring(i, 1));
                        int Sum = (Top + Bottom);

                        if ((Sum >= 10))
                        {
                            Sum -= 10;
                            Remainder = 1;
                        }
                        else
                        {
                            Remainder = 0;
                        }
                        SumString = Sum.ToString() + SumString;
                    }

                    for (int i = Pref.Length - 1; i >= 0; i--)
                    {
                        int Top = int.Parse(Pref.Substring(i, 1)) + Remainder;
                        if ((Top >= 10) && (i != 0))
                        {
                            Top -= 10;
                            Remainder = 1;
                        }
                        else
                        {
                            Remainder = 0;
                        }
                        SumString = Top.ToString() + SumString;
                    }
                }

            }

            return new BigInteger(SumString);
        }

        //Multiplication with Integer
        public BigInteger Multiply(int Limit)
        {
            BigInteger ProductInt = new BigInteger("0");
            int Count = 0;
            while (Count < Limit)
            {
                ProductInt = ProductInt.Add(this);
                Count++;
            }
            return ProductInt;
        }

        //Multiplication with BigInteger as argument instead
        public BigInteger BigMultiply(BigInteger Limit)
        {
            BigInteger Product = new BigInteger("0");
            BigInteger Count = new BigInteger("0");
            BigInteger Increment = new BigInteger("1");
            while (Count.LessThan(Limit))
            {
                Product = Product.Add(this);
                Count = Count.Add(Increment);
            }
            return Product;
        }
    }

}
