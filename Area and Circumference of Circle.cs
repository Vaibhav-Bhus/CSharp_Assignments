using System;

class Program
{
    static void Main(string[] args)
    {
        double radius, area, circumference;
        const double PI = 3.14159;

        Console.Write("Enter the radius of the circle: ");
        radius = double.Parse(Console.ReadLine());

        area = PI * radius * radius;
        circumference = 2 * PI * radius;

        Console.WriteLine($"Area of the circle: {area}");
        Console.WriteLine($"Circumference of the circle: {circumference}");
    }
}
