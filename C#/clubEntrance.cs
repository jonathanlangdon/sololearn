// practice with if else statements

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());
        
        if (age >= 16)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Not allowed");
        }
        
    }
}