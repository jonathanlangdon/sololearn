//categorize countries if they are small or not

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int population = Convert.ToInt32(Console.ReadLine());
        int area = Convert.ToInt32(Console.ReadLine());
        
        int minSizeLarge = 10000;

        if (population < minSizeLarge && area < minSizeLarge)
        {
            Console.WriteLine("small country");
        }
        
        
    }
}