using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapVeAbstract
{
    class TamGiac:DoanThang
    {
        private Diem d3;

        public TamGiac(Diem d1, Diem d2, Diem d3) : base(d1, d2)
        {
            name = "TamGiac";
            this.d3 = d3;
        }
        public override double ChuVi()
        {
            DoanThang c1 = new DoanThang(d1, d2);
            DoanThang c2 = new DoanThang(d2, d3);
            DoanThang c3 = new DoanThang(d3, d1);
            double chuvi = c1.ChuVi() + c2.ChuVi() + c3.ChuVi();
            return chuvi;
        }
        public override int CompareTo(HinhHoc hh)
        {
            if(ChuVi() < hh.ChuVi())
            {
                return 1;
            }
            else if( ChuVi() > hh.ChuVi())
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
            Console.WriteLine("Co chu vi la: " + ChuVi());
        }
    }
}
