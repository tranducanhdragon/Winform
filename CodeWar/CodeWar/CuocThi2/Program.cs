using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocThi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "190920175400 vietcv", "190919175401 vietcv" };
            string[] str = AttackList(s, 1440, 2);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "NULL")
                {
                    Console.WriteLine(" " + str[i]);

                }

            }
            Console.ReadKey();
        }
        static string[] AttackList(string[] accessList, int m, int n)
        {
            int acc_length = accessList.Length;

            List<Nguoi> ds = new List<Nguoi>();
            for (int i = 0; i < acc_length; i++)
            {
                Nguoi ng = new Nguoi();
                string[] s = new string[3];
                s = accessList[i].Split(' ');

                int nam = Int32.Parse(s[0].Substring(0, 2));
                int thang = Int32.Parse(s[0].Substring(2, 2));
                int ngay = Int32.Parse(s[0].Substring(4, 2));
                int gio = Int32.Parse(s[0].Substring(6, 2));
                int phut = Int32.Parse(s[0].Substring(8, 2));
                int giay = Int32.Parse(s[0].Substring(10, 2));
                ng.ten = s[1];
                ng.dt = new DateTime(nam, thang, ngay, gio, phut, giay);
                ds.Add(ng);

            }
            List<string> dsat = new List<string>();
            ds.Sort((x, y) => DateTime.Compare(x.Created, y.Created));

            for (int i = accessList.Length - 1; i >= 1; i--)
            {
                double[] h = new double[accessList.Length];
                TimeSpan t = new TimeSpan();
                int dem = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ds[i].ten == ds[j].ten)
                    {
                        t = ds[i].dt - ds[j].dt;
                        h[dem - 1] = t.TotalMinutes;
                        dem++;

                    }
                    else if (n == 1)
                    {
                        t = ds[i].dt - ds[i].dt;
                        h[dem - 1] = t.TotalMinutes;
                        dem++;
                    }
                }

                for (int k = 0; k < dem - 1; k++)
                {
                    if (h[k] <= m && dem > n)
                    {
                        dsat.Add(ds[i].ten);
                    }

                }

            }
            dsat.Sort();
            string[] acc = dsat.Distinct().ToArray();

            return acc;
        }
        struct Nguoi
        {
            public string ten { get; set; }
            public DateTime dt { get; set; }

            public DateTime Created { get; internal set; }
        }
    }
}
