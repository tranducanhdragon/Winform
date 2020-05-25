using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapVeAbstract
{
    abstract class HinhHoc: IComparable<HinhHoc>
    {
        protected string name = "HinhHoc";

        public virtual void HienThi()
        {
            Console.WriteLine("Day la: " + name);
        }
        public abstract double ChuVi();

        public abstract int CompareTo(HinhHoc hh);
        
    }

}
