using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapVeAbstract
{
    class Diem:HinhHoc
    {
        protected int X, Y;

        public Diem(int a, int b)
        {
            name = "Diem";
            X = a;
            Y = b;
        }

        public int x
        {
            get { return X; }
            set { X = value; }
        }
        public int y
        {
            get { return Y; }
            set { Y = value; }
        }

        public override int CompareTo(HinhHoc hh)
        {
            if( ChuVi() > hh.ChuVi())
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

        public override double ChuVi()
        {
            return 0;
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Co chu vi la: " + this.ChuVi());
        }
    }
}
