// practice using a dictionary

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        var colorDictionary = new Dictionary<int, string>
        {
            {1, "Light"}, {2, "Dark"}, {3, "Indigo"}
        };

        Console.WriteLine(colorDictionary[number]);
        
        
    }
}