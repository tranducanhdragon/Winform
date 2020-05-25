using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape hinhtron = new Circle(5);
            hinhtron.GetInfor();

            Shape hinhchunhat = new Retangle(1, 9);
            hinhchunhat.GetInfor();

            Shape hinhtamgiac = new Triangle(3, 4, 5);
            hinhtamgiac.GetInfor();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(4));
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Retangle(5, 3));
            
            shapes.Sort();
            foreach (Shape s in shapes)
            {
                s.GetInfor();
            }
            
        }
    }
}
