// practice using string interpolation

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{number1}+{number2}={number1 + number2}");
        
    }
}