using System;

class StringManipulationsBuiltIn
{
    static void Main()
    {
        string inputString = "Hello, World!";
        
        
        int length = inputString.Length;
        Console.WriteLine("Length of the string: " + length);

        
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine("Reversed string: " + reversedString);

                string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        Console.WriteLine("Number of words: " + wordCount);

        string upperCaseString = inputString.ToUpper();
        Console.WriteLine("Uppercase string: " + upperCaseString);
    }
}
