using System;

class Program
{
    static void Main(string[] args)
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter the number of terms: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write($"{first} ");
            }
            else if (i == 2)
            {
                Console.Write($"{second} ");
            }
            else
            {
                next = first + second;
                Console.Write($"{next} ");
                first = second;
                second = next;
            }
        }
    }
}
