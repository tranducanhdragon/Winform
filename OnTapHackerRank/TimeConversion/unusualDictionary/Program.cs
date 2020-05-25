using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unusualDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = {"a",
 "an a",
 "to a",
 "a b",
 "b",
 "to b"};
            bool s = unusualDictionary2(t);
            Console.WriteLine(s);
            Console.Read();
        }
        static bool unusualDictionary2(string[] L)
        {
            int k, l, t;
            //compare L[i] and L[i+1], if the string after space are the same
            //then check the string from beginning to end
            for (int i = 0; i < L.Length - 1; i++)
            {
                k = L[i].IndexOf(' ');
                l = L[i + 1].IndexOf(' ');

                t = String.Compare(L[i].Substring(k + 1), L[i + 1].Substring(l + 1));
                if (t == 0)
                {
                    if (string.Compare(L[i].Substring(0), L[i + 1].Substring(0)) > 0)
                        return false;

                }
                else if (t > 0)
                    return false;
            }
            return true;
        }
        static bool unusualDictionary(string[] L)
        {
            int n = L.Length;
            string[,] dic = new string[n, 2];
            for (int i = 0; i < n; i++)
            {
                string[] temp = L[i].Split(' ');
                if (L[i].IndexOf(' ') != -1)
                {

                    dic[i, 0] = temp[0];
                    dic[i, 1] = temp[1];
                }
                else
                {
                    dic[i, 0] = temp[0];
                    dic[i, 1] = temp[0];
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(dic[i, 1], dic[j, 1]) == 0)
                    {
                        if (string.Compare(dic[i, 0], dic[j, 0]) > 0)
                            return false;
                    }
                    else if (string.Compare(dic[i, 1], dic[j, 1]) > 0)
                        return false;
                }
            }
            return true;
        }
    }
}
