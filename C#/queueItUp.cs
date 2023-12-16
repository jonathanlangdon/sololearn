// working with Queues

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
            Queue<int> q = new Queue<int>();

            while (q.Count<3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            
            Console.Write("Sorted: ");
            //your code goes here
            int[] arr = q.ToArray();
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}