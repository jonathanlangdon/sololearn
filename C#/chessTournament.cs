// chess tournament score - practice with Convert.ToInt32() for type conversion

using System;

public class Program
{
    static void Main(string[] args)
    {
        int wins;
        int winWorth = 1;
        int ties;
        double tieWorth = 0.5;

        wins = Convert.ToInt32(Console.ReadLine());
        ties = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(wins * winWorth + ties * tieWorth);
        
    }
}

