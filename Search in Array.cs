using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 4, 9 };
        int searchNumber = 8;
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"The number {searchNumber} was found in the array.");
        }
        else
        {
            Console.WriteLine($"The number {searchNumber} was not found in the array.");
        }
    }
}
