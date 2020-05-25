using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapVeAbstract
{
    class DoanThang:HinhHoc
    {
        protected Diem d1, d2;

        public DoanThang(Diem d1, Diem d2)
        {
            name = "DoanThang";
            this.d1 = d1;
            this.d2 = d2;
        }
        public override double ChuVi()
        {
            double t = 0;
            t = Math.Sqrt(Math.Pow((d1.x - d2.x), 2) + Math.Pow(d1.y - d2.y , 2));
            return t;
        }
        public override int CompareTo(HinhHoc hh)
        {
            if(ChuVi() > hh.ChuVi())
            {
                return 1;
            }
            else if(ChuVi() < hh.ChuVi())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override void HienThi()
        {
            base.HienThi();
            /*Console.WriteLine("Co chu vi la: " + ChuVi());*/
        }
    }
}
