// check a password for invalid characters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            //your code goes here
            foreach (char letter in password) {
                if (notAllowedSymbols.Contains(letter)) {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
            
        }
    }
}