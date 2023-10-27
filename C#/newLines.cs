// split a string into it's characters and put them on their own lines using StringBuilder

using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        string text = "ABCD";
        var charArray = text.ToCharArray();
        StringBuilder newText = new StringBuilder("");
        foreach(char c in charArray)
        {
            newText.Append(c + "\n");
        }
        string newString = newText.ToString();
        Console.WriteLine(newString);
    }
}


// can also do this without string builder:

using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        string text = "ABCD";
        var charArray = text.ToCharArray();
        foreach(char c in charArray)
        {
            Console.WriteLine(c);
        }
    }
}