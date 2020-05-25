using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine md1 = new Medicine();
            md1.Accept();
            md1.Show();
            
            Console.ReadLine();
        }

    }

    class Medicine
    {
        private string Medicine_Code;
        private double Unit_Price;
        private int Quantity_On_Hand;


        public Medicine() {
            Medicine_Code = "NULL";
            Unit_Price = 0;
            Quantity_On_Hand = 0;
        }

        public string MedicineCode{
            
            get { return Medicine_Code; }
            set { Medicine_Code = value; }
        }
        
        public double UnitPrice
        {
            
            get { return Unit_Price; }
            set { Unit_Price = value; }
        }
        public int QuantityOnHand
        {
            
            get { return Quantity_On_Hand; }
            set { Quantity_On_Hand = value; }
        }


        public void Accept()
        {
            Console.WriteLine("Nhap du lieu: ");
            Console.WriteLine("Medicine code: ");
            Medicine_Code = Console.ReadLine();
            Console.WriteLine("Unit price: ");
            Unit_Price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Quantity on hand: ");
            Quantity_On_Hand = Int32.Parse(Console.ReadLine());

        }
        public void Show()
        {
            Console.WriteLine("Medicine code: {0}", Medicine_Code);
            Console.WriteLine("Unit price: {0}", Unit_Price);
            Console.WriteLine("Quantity on hand: {0}", Quantity_On_Hand);
        }
    }
    
}
