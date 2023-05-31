using System;

class AverageCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter numbers (separated by spaces):");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int sum = 0;

        foreach (string number in numbers)
        {
            int num;
            if (int.TryParse(number, out num))
            {
                sum += num;
            }
        }

        double average = (double)sum / numbers.Length;
        Console.WriteLine("Average: " + average);
    }
}
