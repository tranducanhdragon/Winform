using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        static int count = 0;

        public Box(double le, double wi, double he)
        {
            length = le;
            width = wi;
            height = he;
            count += 1;
        }
        public Box()
        {
            length = 0;
            width = 0;
            height = 0;
            count += 1;
        }
        public void Show()
        {
            Console.WriteLine("{0}, {1}, {2}", length, width, height);
            Console.WriteLine("So luong object: " + count);
        }
        public double TheTich()
        {
            return length * width * height;
        }
        public void TheTich1(out double v)
        {
            v = length * width * height;
        }

        public double Length
        {
            get { return length; }
            set {
                if(value < 10 && value > 0)
                length = value;
                else
                {
                    Console.WriteLine("So nay khong hop le!");
                }
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }

        public static Box operator + (Box box1, Box box2)
        {
            Box box = new Box();
            box.length = box1.length + box2.length;
            box.width = box1.width + box2.width;
            box.height = box1.height + box.height;
            return box;
        }
        public static bool operator >(Box box1, Box box2)
        {
            double v1 = box1.TheTich();
            double v2 = box2.TheTich();
            if(v1 > v2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Box box1, Box box2)
        {
            double v1 = box1.TheTich();
            double v2 = box2.TheTich();
            if (v1 < v2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(4,5,6);
            box1.Show();

            Box box2 = new Box(7,8,9);

            Box box3 = new Box(1, 2, 3);
            box3.Show();

            Console.WriteLine("The tich: {0}", box3.TheTich());

            double v;
            box3.TheTich1(out v);
            Console.WriteLine("The tich {0}", v);

            box3.Length = 5;
            box3.Show();

            Box box12 = box1 + box2;
            box12.Show();

            Console.WriteLine("Box1 lon hon Box2 la: {0} ", box1 > box2);
        }
    }
}
