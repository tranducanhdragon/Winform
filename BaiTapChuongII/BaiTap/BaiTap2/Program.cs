using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> ds = new List<SinhVien>(2);

            for(int i=0; i<2; i++)
            {
                SinhVien sv = new SinhVien();
                string s = Console.ReadLine();
                string[] t = s.Split(',');
                sv.setTen(t[0]);
                sv.setNgay(int.Parse(t[1]));
                sv.setThang(int.Parse(t[2]));
                sv.setNam(int.Parse(t[3]));
                sv.setQueQuan(t[4]);
                sv.setLop(t[5]);
                ds.Add(sv);
                
            }
            foreach(SinhVien i in ds)
            {
                if((2019 - i.getNam()) > 19 && (2019 - i.getNam() < 22))
                {
                    Console.WriteLine("Sinh vien tuoi tu 19 - 22: " + i.getTen());
                }
            }
            Console.Read();
        }
    }
    class SinhVien
    {
        protected string ten;
        protected int ngay;
        protected int thang;
        protected int nam;
        string que_quan;
        string lop;

        public void setTen(string ten)
        {
            this.ten = ten;
        }
        public string getTen()
        {
            return ten;
        }

        public void setNgay(int ngay)
        {
            this.ngay = ngay;
        }
        public int getNgay()
        {
            return ngay;
        }

        public void setThang(int thang)
        {
            this.thang = thang;
        }
        public int getThang()
        {
            return thang;
        }

        public void setNam(int nam)
        {
            this.nam = nam;
        }
        public int getNam()
        {
            return nam;
        }

        public void setQueQuan(string quequan)
        {
            this.que_quan = quequan;
        }
        public string getQueQuan()
        {
            return que_quan;
        }

        public void setLop(string lop)
        {
            this.lop = lop;
        }
        public string getLop()
        {
            return lop;
        }
    }
}
