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
            Console.WriteLine("" + numberOfZeroDigits(30));
            Console.ReadKey();
        }
        static long numberOfZeroDigits(long n)
        {
            long dem = 0;
            ulong[] res = new ulong[] { };
            res = fn(n);
            for(long i = 0; i < res.Length-1; i++)
            {
                if(res[i] == 0)
                {
                    dem++;
                }
                else if(res[i] != 0)
                {
                    break;
                }
                else
                {
                    break;
                }
            }
            return dem;
        }

        static ulong[] fn(long n)
        {

            ulong[] res1 = new ulong[] { };
            ulong[] res2 = new ulong[] { };
            res2 = factorial(1);
            for(int i = 2; i<=n; i++)
            {
                res1 = factorial(i);
                res2 = MultiplyDigitArrays(ref res2, res1);
            }
            return res2;
        }
        static ulong[] factorial(int n)
        {
            int res_len = n;
            ulong[] res = new ulong[n];
            res[0] = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (res[i] == 0)
                {
                    res_len--;
                }
                else
                {
                    break;
                }
            }
            System.Array.Resize<ulong>(ref res, res_len);
            int res_size = 1;
            for (int x = 2; x <= n; x++)
            {
                res_size = multiply(x, ref res, res_size);
            }

            return res;
        }
        static int multiply(int x, ref ulong[] res, int res_size)
        {
            ulong carry = 0;
            for (int i = 0; i < res_size; i++)
            {
                ulong prod = res[i] * (ulong)x + carry;
                res[i] = prod % 10;

                carry = prod / 10;
            }
            while (carry != 0)
            {
                System.Array.Resize<ulong>(ref res, res_size + 1);
                res[res_size] = carry % 10;
                carry = carry / 10;
                res_size++;
            }
            return res_size;
        }

        public static ulong[] MultiplyDigitArrays(ref ulong[] lhs, ulong[] rhs)
        {
            int lhs_len = lhs.Length;
            
            for(long i = lhs.Length-1; i>=0; i--)
            {
                if(lhs[i] == 0)
                {
                    lhs_len--;
                }
                else
                {
                    break;
                }
            }
            System.Array.Resize<ulong>(ref lhs, lhs_len);
            
            int rhs_len = rhs.Length;
            for(int i = rhs.Length-1; i>=0; i--)
            {
                if (rhs[i] == 0)
                {
                    rhs_len--;
                }
                else
                {
                    break;
                }
            }
            System.Array.Resize<ulong>(ref rhs, rhs_len);
            
            int length1 = Math.Max(lhs_len, rhs_len);
            ulong[] result = new ulong[length1*length1];
            for (int i = 0; i < length1; i++)
            {
                ulong[] PartialProduct = new ulong[(length1*length1)+1];

                int length2 = Math.Min(lhs_len, rhs_len);
                for (int j = 0; j < length2; j++)
                {
                    ulong multiplicand = (lhs_len < rhs_len) ? rhs[i] : lhs[i];
                    ulong multiplier = (lhs_len < rhs_len) ? lhs[j] : rhs[j];

                    ulong product = PartialProduct[i + j] + multiplicand * multiplier;

                    PartialProduct[i + j] = product % 10;
                    ulong carry = product / 10;

                    PartialProduct[i + j + 1] = PartialProduct[i + j + 1] + carry;
                }
                result = SumDigitArrays(PartialProduct, result);
            }
            return result;
        }

        public static ulong[] SumDigitArrays(ulong[] a, ulong[] b)
        {
            int a_len = a.Length;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == 0)
                {
                    a_len--;
                }
                else
                {
                    break;
                }
            }
            System.Array.Resize<ulong>(ref a, a_len);
            int b_len = b.Length;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] == 0)
                {
                    b_len--;
                }
                else
                {
                    break;
                }
            }
            System.Array.Resize<ulong>(ref b, b_len);
            int length = Math.Max(a_len, b_len);
            ulong[] result = new ulong[length];
            for (int i = 0; i < length; i++)
            {
                ulong lhs = (i < a_len) ? a[i] : 0;
                ulong rhs = (i < b_len) ? b[i] : 0;

                ulong sum = result[i] + lhs + rhs;
                result[i] = sum % 10;

                ulong carry = sum / 10;

                if (i + 1 < result.Length)
                {
                    result[i + 1] = result[i + 1] + carry;
                }
            }
            return result;
        }
    }

}
