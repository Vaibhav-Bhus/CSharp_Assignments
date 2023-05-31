using System;

class StringManipulations
{
    static void Main()
    {
        string inputString = "Hello, World!";
        
        
        int length = 0;
        foreach (char c in inputString)
        {
            length++;
        }
        Console.WriteLine("Length of the string: " + length);

        
        string reversedString = "";
        for (int i = length - 1; i >= 0; i--)
        {
            reversedString += inputString[i];
        }
        Console.WriteLine("Reversed string: " + reversedString);

        
        int wordCount = 0;
        bool isWord = false;
        foreach (char c in inputString)
        {
            if (char.IsLetter(c))
            {
                if (!isWord)
                {
                    wordCount++;
                    isWord = true;
                }
            }
            else
            {
                isWord = false;
            }
        }
        Console.WriteLine("Number of words: " + wordCount);

        
        string upperCaseString = "";
        foreach (char c in inputString)
        {
            if (char.IsLower(c))
            {
                upperCaseString += (char)(c - 32);
            }
            else
            {
                upperCaseString += c;
            }
        }
        Console.WriteLine("Uppercase string: " + upperCaseString);
    }
}
