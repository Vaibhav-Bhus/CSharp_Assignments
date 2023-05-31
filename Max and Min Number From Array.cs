using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 4, 9 };
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Maximum number: {max}");
        Console.WriteLine($"Minimum number: {min}");
    }
}
