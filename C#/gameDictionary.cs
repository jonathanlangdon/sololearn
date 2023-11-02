// select a game using a dictionary

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Run(number);
    }

    static void Run(int number)
    {
        var gameDictionary = new Dictionary<int, string>
        {
            {1, "Shooter"}, {2, "Puzzle"}, {3, "Snake"}
        };
        Console.WriteLine(gameDictionary[number]);
    }
}