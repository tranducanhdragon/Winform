using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DelegateVaFile
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;
        public delegate void PrintString(string s);
        public static void WriteToConsole(string s)
        {
            Console.WriteLine("The string is {0}", s);
        }
        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void SendString(PrintString ps)
        {
            ps("Hello world!");
        }
        static void Main(string[] args)
        {
            PrintString ps1 = new PrintString(WriteToConsole);
            PrintString ps2 = new PrintString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
            Console.Read();
        }
    }
}
