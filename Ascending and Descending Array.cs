using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 4, 9 };

        Console.WriteLine("Original Array:");
        DisplayArray(numbers);

        Array.Sort(numbers);
        Console.WriteLine("Array in Ascending Order:");
        DisplayArray(numbers);

        Array.Reverse(numbers);
        Console.WriteLine("Array in Descending Order:");
        DisplayArray(numbers);
    }

    static void DisplayArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
