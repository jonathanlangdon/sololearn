// use for loop to calculator factorial

using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
        
    }
}