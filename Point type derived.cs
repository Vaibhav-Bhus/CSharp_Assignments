using System;

class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Point otherPoint = (Point)obj;
        return x == otherPoint.x && y == otherPoint.y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(3, 4);
        Point point2 = new Point(3, 4);

        Console.WriteLine(point1.ToString());
        Console.WriteLine(point1.Equals(point2)); 

        Console.WriteLine(point1.GetHashCode()); 
        Console.WriteLine(point2.GetHashCode()); 
    }
}
