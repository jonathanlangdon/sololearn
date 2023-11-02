// determine which floors of a building have restaurants.  every 5th floor has a restaurant

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int floors = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= floors; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}