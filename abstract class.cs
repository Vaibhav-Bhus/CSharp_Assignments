using System;

abstract class Person
{
    protected string name;
    protected int age;

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract decimal CalculateAnnualTax();
}

class Employee : Person
{
    protected string designation;
    protected decimal salary;

    public string Designation { get => designation; set => designation = value; }
    public decimal Salary { get => salary; set => salary = value; }

    public Employee(string name, int age, string designation, decimal salary)
        : base(name, age)
    {
        Designation = designation;
        Salary = salary;
    }

    public override decimal CalculateAnnualTax()
    {
        decimal annualTax = Salary * 0.15m; // Assuming a tax rate of 15%
        return annualTax;
    }
}

class Company : Employee
{
    protected string company_name;
    protected int total_emp;

    public string CompanyName { get => company_name; set => company_name = value; }
    public int TotalEmployees { get => total_emp; set => total_emp = value; }

    public Company(string name, int age, string designation, decimal salary, string company_name, int total_emp)
        : base(name, age, designation, salary)
    {
        CompanyName = company_name;
        TotalEmployees = total_emp;
    }

    public void DisplayCompanyInfo()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Total Employees: " + TotalEmployees);
    }
}

class Program
{
    static void Main()
    {
        string name = "Aniket Muley";
        int age = 30;
        string designation = "Manager";
        decimal salary = 50000;
        string company_name = "ABC Company";
        int total_emp = 1000;

        Company employee = new Company(name, age, designation, salary, company_name, total_emp);

        Console.WriteLine("Employee Information:");
        Console.WriteLine("Name: " + employee.Name);
        Console.WriteLine("Age: " + employee.Age);
        Console.WriteLine("Designation: " + employee.Designation);
        Console.WriteLine("Salary: " + employee.Salary);
        Console.WriteLine("Company Name: " + employee.CompanyName);
        Console.WriteLine("Total Employees: " + employee.TotalEmployees);
        Console.WriteLine("Annual Tax: " + employee.CalculateAnnualTax());
    }
}
