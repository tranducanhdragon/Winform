using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    public abstract class Shape: IComparable<Shape>
    {
        protected string name = "Shape";
        public virtual void GetInfor() {
            Console.WriteLine("Day la {0}", name);
        }
        public abstract double Area();
        public abstract int CompareTo(Shape other);
    }
}
