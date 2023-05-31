using System;

class Program
{
    static void Main(string[] args)
    {
        int number, factorial = 1;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is {factorial}.");
    }
}
