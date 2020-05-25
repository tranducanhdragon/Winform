using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12:00:00PM";
            string result = timeConversion(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        
        static string timeConversion(string s)
        {
            string[] s_split = new string[4] ;
            int t = 0;
            for (int i = 0; i < s.Length - 2; i = i+3)
            {
                s_split[t] =  s.Substring(i, 2);
                t++;
            }
            s_split[t] = s.Substring(s.Length - 2, 2);
            t++;
            double[] result = new double[3];
            for(int i = 0; i < 3; i++)
            {
                result[i] = double.Parse(s_split[i]);
            }

            string timeconver = "";
            if(result[0] >= 1 && result[0] < 12 && s_split[3] == "AM")
            {
                timeconver = s_split[0] + ":";
            }
            else if(s_split[3] == "PM" && result[0] != 12)
            {
                timeconver = (result[0] + 12).ToString() + ":";
            }
            else if(result[0] == 12 && s_split[3] == "AM")
            {
                timeconver = "00" + ":";
            }
            else if(result[0] == 12 && s_split[3] == "PM")
            {
                timeconver = "12" + ":";
            }

            if(result[1] >= 0 && result[1] <= 59 )
            {
                timeconver += s_split[1] + ":";
            }
            if (result[2] >= 0 && result[2] <= 59)
            {
                timeconver += s_split[2];
            }
            return timeconver;
        }
    }
}
