using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class Triangle: Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            name = "Triangle";
        }

        public override void GetInfor()
        {
            base.GetInfor();
            Console.WriteLine("Hinh tam giac co 3 canh la {0}, {1}, {2} ", a, b, c);
            Console.WriteLine("Dien tich hinh tam giac la {0:f2}", Area());
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            double  s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
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
