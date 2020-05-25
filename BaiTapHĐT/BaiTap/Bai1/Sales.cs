using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Sales
    {
        private string Medicine_code;
        private int Quantity_sold;
        private string Planned_sales;
        private string Actual_sales;
        private string Region;

        public Sales()
        {
            Medicine_code = "NULL";
            Quantity_sold = 0;
            Planned_sales = "NULL";
            Actual_sales = "NULL";
            Region = "NULL";
        }

        public void Accept()
        {
            Console.WriteLine("Nhap medicine code: ");
            Medicine_code = Console.ReadLine();
            Console.WriteLine("Nhap quantity sold: ");
            Quantity_sold = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap plannded sales: ");
            Planned_sales = Console.ReadLine();
            Console.WriteLine("Nhap actual sales: ");
            Actual_sales = Console.ReadLine();
            Console.WriteLine("Nhap region: ");
            Region = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Medicine code: "+ Medicine_code);
            Console.WriteLine("Quantity sold: "+ Quantity_sold);
            Console.WriteLine("Region: " + Region);
        }
        public void Print1()
        {
            Console.WriteLine("Plannded sales: "+ Planned_sales);
            Console.WriteLine("Actual sales: "+ Actual_sales);
        }
    }

}
