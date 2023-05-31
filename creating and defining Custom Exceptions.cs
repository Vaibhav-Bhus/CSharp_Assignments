using System;

public class NotPrimeException : Exception
{
    public NotPrimeException(string message) : base(message)
    {
    }
}

public class PrimeNumberGenerator
{
    public int[] GetPrimeSequence(int startingNumber, int count)
    {
        if (!IsPrime(startingNumber))
        {
            throw new NotPrimeException("Starting number is not prime.");
        }

        int[] primes = new int[count];
        int primeCount = 0;
        int currentNumber = startingNumber;

        while (primeCount < count)
        {
            if (IsPrime(currentNumber))
            {
                primes[primeCount] = currentNumber;
                primeCount++;
            }

            currentNumber++;
        }

        return primes;
    }

    private bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        int startingNumber = 4;
        int count = 5;

        try
        {
            PrimeNumberGenerator generator = new PrimeNumberGenerator();
            int[] primes = generator.GetPrimeSequence(startingNumber, count);

            Console.WriteLine("Prime numbers:");
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
        catch (NotPrimeException ex)
        {
            Console.WriteLine("NotPrimeException caught: " + ex.Message);
        }
    }
}
