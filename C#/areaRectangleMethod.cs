// create and call a method called Area

using System;

public class Program
{
    static void Main(string[] args)
    {
        int width = Convert.ToInt32(Console.ReadLine());
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Area(width, length));
        
    }

    static int Area(int width, int length)
    {
        return width * length;
    }
}