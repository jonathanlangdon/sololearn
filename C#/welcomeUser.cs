// call a method called Welcome

using System;

public class Program
{
    static void Main(string[] args)
    {
        Welcome();
        
    }

    static void Welcome()
    {
        string user = Console.ReadLine();
        Console.WriteLine($"Welcome, {user}!");
    }
}