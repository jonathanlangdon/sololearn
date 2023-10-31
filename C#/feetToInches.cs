// convert feet to inches method

 using System;

public class Program
{
    static void Main(string[] args)
    {
        double foot = Convert.ToDouble(Console.ReadLine());
        Converter(foot);
    }

    static void Converter(double foot)
    {
        Console.WriteLine(foot * 12);
    }
    
}