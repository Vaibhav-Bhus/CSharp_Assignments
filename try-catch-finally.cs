using System;

class Program
{
    static void Main()
    {
        int dividend = 10;
        int divisor = 0;
        int result;

        try
        {
            result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException caught: " + ex.Message);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("ArithmeticException caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}
    