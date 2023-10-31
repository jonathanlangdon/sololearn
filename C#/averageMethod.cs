// take in 3 doubles and return average

using System;

public class Program
{
    public static void Main(string[] args)
    {
        double score1 = Convert.ToInt32(Console.ReadLine());
        double score2 = Convert.ToInt32(Console.ReadLine());
        double score3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Average(score1,score2,score3));
    }

    static double Average(double score1, double score2, double score3)
    {
        return (score1 + score2 + score3) / 3;
    }
}