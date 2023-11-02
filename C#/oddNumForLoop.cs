// use a for loop to find all odd numbers from 0 to a num

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= number; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
        
        
    }
}