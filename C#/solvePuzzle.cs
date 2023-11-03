// practice with Arrays

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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber < 0 || userNumber >= games.Length)
            {
              Console.WriteLine("Invalid number");
            }
            else
            {
              Console.WriteLine(games[userNumber]);
            }
            
        }
    }
}