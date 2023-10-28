// practice with dictionaries and interpolated strings

using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var color = Console.ReadLine();

        var colorBox = new Dictionary<string, string>
        {
            {"red", "box #1"},
            {"green", "box #2"},
            {"black", "box #3"}
        };

        if (colorBox.ContainsKey(color))
        {
            Console.WriteLine($"{colorBox[color]}");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
