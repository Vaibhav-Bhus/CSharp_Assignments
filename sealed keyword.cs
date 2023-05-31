using System;

class StudentResult
{
    protected string studentName;
    protected int marks;

    public StudentResult(string studentName, int marks)
    {
        this.studentName = studentName;
        this.marks = marks;
    }

    public virtual void CalculateGrade()
    {
        if (marks >= 90)
            Console.WriteLine("Grade: A");
        else if (marks >= 80)
            Console.WriteLine("Grade: B");
        else if (marks >= 70)
            Console.WriteLine("Grade: C");
        else if (marks >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}

sealed class FinalResult : StudentResult
{
    public FinalResult(string studentName, int marks)
        : base(studentName, marks)
    {
    }

    public sealed override void CalculateGrade()
    {
        Console.WriteLine("Final Grade Calculation:");
        base.CalculateGrade();
    }
}

class Program
{
    static void Main()
    {
        string studentName = "Omkar";
        int marks = 85;

        FinalResult result = new FinalResult(studentName, marks);

        Console.WriteLine("Student Result:");
        result.CalculateGrade();
    }
}
