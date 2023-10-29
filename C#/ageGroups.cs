// practice with if statements

using System;

public class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("Child");
        }
        else if (age < 18)
        {
            Console.WriteLine("Teen");
        }
        else
        {
            Console.WriteLine("Adult");
        }
        
    }
}