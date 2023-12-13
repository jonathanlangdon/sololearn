// get user input and output sum of max and min values

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
            int inputCount = 5;
            int[] inputArr = new int [5];
            while (inputCount > 0) {
                int inputNum = int.Parse(Console.ReadLine());
                inputArr[inputCount - 1] = inputNum;
                inputCount -= 1;
            }
            int max = inputArr.Max();
            int min = inputArr.Min();
            Console.WriteLine(max + min);
        }
    }
}