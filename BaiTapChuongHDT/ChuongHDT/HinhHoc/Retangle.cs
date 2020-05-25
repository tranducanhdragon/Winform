using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    public class Retangle:Shape
    {
        private double length;
        private double width;

        public Retangle(double l, double w)
        {
            length = l;
            width = w;
            name = "Retangle";
        }
        public override void GetInfor()
        {
            base.GetInfor();
            Console.WriteLine("Chieu dai la {0} va chieu rong la {1}", length, width);
            Console.WriteLine("Dien tich hinh chu nhat la {0:f2}", Area());
        }
        public override double Area()
        {
            return length * width;
        }
        public override int CompareTo(Shape other)
        {
            if (Area() < other.Area())
            {
                return 1;
            }
            else if (Area() > other.Area())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
