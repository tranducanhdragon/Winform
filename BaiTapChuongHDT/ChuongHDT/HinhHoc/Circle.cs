using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class Circle: Shape
    {
        private double radius;

        public Circle( double r) {
            radius = r;
            name = "Circle";
        }
        public override void GetInfor()
        {
            base.GetInfor();
            Console.WriteLine("Ban kinh la {0}", radius);
            Console.WriteLine("Dien tich la {0:f2}", Area());
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override int CompareTo(Shape other)
        {
            if(Area() < other.Area())
            {
                return 1;
            }
            else if(Area() > other.Area())
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
