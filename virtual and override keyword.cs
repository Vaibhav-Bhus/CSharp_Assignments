using System;

class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Adhar_card : Person
{
    protected string ssn;

    public Adhar_card(string name, int age, string ssn)
        : base(name, age)
    {
        this.ssn = ssn;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Social Security Number: " + ssn);
    }
}

class Program
{
    static void Main()
    {
        string name = "Aniket Muley";
        int age = 30;
        string ssn = "123-45-6789";

        Adhar_card person = new Adhar_card(name, age, ssn);

        Console.WriteLine("Person Information:");
        person.DisplayInfo();
    }
}
