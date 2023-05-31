using System;

class Grandparent
{
    protected string name;
    protected int age;

    public Grandparent(string name, int age)
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

class Parent : Grandparent
{
    protected string education;

    public Parent(string name, int age, string education)
        : base(name, age)
    {
        this.education = education;
    }

    public void DisplayEducation()
    {
        Console.WriteLine("Education: " + education);
    }
}

class Child : Parent
{
    private string maritalStatus;

    public Child(string name, int age, string education, string maritalStatus)
        : base(name, age, education)
    {
        this.maritalStatus = maritalStatus;
    }

    public void DisplayMaritalStatus()
    {
        Console.WriteLine("Marital Status: " + maritalStatus);
    }
}

class Program
{
    static void Main()
    {
        Grandparent grandparent = new Grandparent("John Doe", 75);
        Parent parent = new Parent("Jane Doe", 50, "Bachelor's Degree");
        Child child = new Child("Alice Doe", 25, "Master's Degree", "Single");

        // Using 'is' keyword to check the type of an object
        Console.WriteLine("Is grandparent an instance of Grandparent? " + (grandparent is Grandparent));
        Console.WriteLine("Is grandparent an instance of Parent? " + (grandparent is Parent));
        Console.WriteLine("Is grandparent an instance of Child? " + (grandparent is Child));

        Console.WriteLine();

        // Using 'as' keyword to cast an object to a different type
        Grandparent grandparentAsParent = parent as Grandparent;
        Grandparent grandparentAsChild = child as Grandparent;

        Console.WriteLine("Parent casted as Grandparent:");
        grandparentAsParent?.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Child casted as Grandparent:");
        grandparentAsChild?.DisplayInfo();
        Console.WriteLine();

        // Displaying information of the child object
        Console.WriteLine("Child Information:");
        child.DisplayInfo();
        child.DisplayEducation();
        child.DisplayMaritalStatus();
    }
}
