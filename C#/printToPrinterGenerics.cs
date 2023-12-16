// use a generic to allow any input type

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        //your code goes here
        public static void Print<T>(T input)
        {
            Console.WriteLine(string.Format($"Showing {input}"));
        }
    }
}