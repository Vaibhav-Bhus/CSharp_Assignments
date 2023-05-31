using System;

public static class StringExtensions
{
    public static int IndexOfCustom(this string str, string searchValue, int startIndex)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str), "Input string cannot be null.");
        }

        return str.IndexOf(searchValue, startIndex);
    }
}

class Program
{
    static void Main()
    {
        string inputString = null;
        string searchValue = "world";
        int startIndex = 0;

        try
        {
            int index = inputString.IndexOfCustom(searchValue, startIndex);
            Console.WriteLine("Index: " + index);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("ArgumentNullException caught: " + ex.Message);
        }
    }
}
