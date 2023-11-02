// use a for loop to sum all numbers from 1 to a number

using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i <= num; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum);
        
    }
}