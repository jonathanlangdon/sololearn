// use while loop to countdown from a number

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        while (number >= 0)
        {
            Console.WriteLine(number);
            number = number - 1;
        }
        
        
    }
}