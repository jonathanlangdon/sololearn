// determine guessing game winner using ternary

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string answer = Console.ReadLine();
        string attempt = Console.ReadLine();

        string result = answer == attempt ? "You win" : "You lose";

        Console.WriteLine(result);
        
        
    }
}