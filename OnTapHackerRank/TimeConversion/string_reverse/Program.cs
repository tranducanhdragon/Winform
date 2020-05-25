using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = reverseInParentheses("foo(bar(baz))blim");

            Console.WriteLine(s);
            Console.ReadKey();
        }

        static string reverseInParentheses(string input)
        {
            if (input == "")
                return "";
            Stack<char> stk = new Stack<char>();
            for(int i = 0; i< input.Length; i++)
            {
                if(input[i] != ')')
                {
                    stk.Push(input[i]);
                }
                else
                {

                    List<char> tmp = new List<char>();//temp list to store chars inside a pair of '()';
                    while (stk.Peek() != '(')
                    {
                        tmp.Add(stk.Pop());
                    }
                    stk.Pop();//get rid of the '(';
                    for (int j = 0; j < tmp.Count(); j++)
                    {
                        stk.Push(tmp.ElementAt(j));//push the reversed characters back to the stack;
                    }

                }
            }
            StringBuilder sb = new StringBuilder();
            while (stk.Any())
            {
                sb.Append(stk.Pop());
            }
            string res = new string(sb.ToString().Reverse().ToArray());
            return res;
        }
    }
}
