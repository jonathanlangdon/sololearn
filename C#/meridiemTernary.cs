// Meridiem determination using ternary

using System;

public class Program
{
    static void Main(string[] args)
    {
        int hour = Convert.ToInt32(Console.ReadLine());

        string meridian = hour < 13 ? "AM" : "PM";
        Console.WriteLine(meridian);
        
    }
}