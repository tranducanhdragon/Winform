using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Medicine
    {
        private string Medicine_code;
        private string Medicine_name;
        private string Manufacturer_name;
        private int Unit_price;
        private int Quantity_on_hand;
        private int Manufactured_date;
        private int Expiry_date;
        private int Batch_number;

        public Medicine()
        {
            Medicine_code = "NULL";
            Medicine_name = "NULL";
            Manufacturer_name = "NULL";
            Unit_price = 0;
            Quantity_on_hand = 0;
            Manufactured_date = 0;
            Expiry_date = 0;
            Batch_number = 0;
        }

        public void Accept()
        {
            Console.WriteLine("Nhap medicine code: ");
            Medicine_code = Console.ReadLine();
            Console.WriteLine("Nhap medicine name: ");
            Medicine_name = Console.ReadLine();
            Console.WriteLine("Nhap manufacturer name: ");
            Manufacturer_name = Console.ReadLine();
            Console.WriteLine("Nhap unit price: ");
            Unit_price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap quantity on hand: ");
            Quantity_on_hand = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap manufacture date: ");
            Manufactured_date = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap expire date: ");
            Expiry_date = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap batch number: ");
            Batch_number = Int32.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Medicine code: "+ Medicine_code);
            Console.WriteLine("Medicine name: " + Medicine_name); 
            Console.WriteLine("Manufacturer name: "+ Manufacturer_name);
            Console.WriteLine("Unit price: "+ Unit_price);
        }
        public void Print(int a = 0)
        {
            Console.WriteLine("Quantity on hand: "+ Quantity_on_hand);
        }
        public void Print(int a = 0, int b = 0)
        {
            Console.WriteLine("Manufacture date: "+ Manufactured_date);
            Console.WriteLine("Expire date: " + Expiry_date);
            Console.WriteLine("Batch number: " + Batch_number);
        }

    }
}
