using System;

interface IGradeCalculator
{
    char CalculateGrade(int marks);
}

class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person, IGradeCalculator
{
    protected int roll_no;
    protected int marks;

    public Student(string name, int age, int roll_no, int marks)
        : base(name, age)
    {
        this.roll_no = roll_no;
        this.marks = marks;
    }

    public char CalculateGrade(int marks)
    {
        if (marks >= 90)
            return 'A';
        else if (marks >= 80)
            return 'B';
        else if (marks >= 70)
            return 'C';
        else if (marks >= 60)
            return 'D';
        else
            return 'F';
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Roll No: " + roll_no);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade(marks));
    }
}

class Program
{
    static void Main()
    {
        string name = "Omkar";
        int age = 18;
        int roll_no = 101;
        int marks = 85;

        Student student = new Student(name, age, roll_no, marks);

        Console.WriteLine("Student Information:");
        student.DisplayInfo();
        student.DisplayStudentInfo();
    }
}
