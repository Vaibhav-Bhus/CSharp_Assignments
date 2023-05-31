using System;

class Employee
{
    private string empId;
    private string post;
    private decimal salary;

    public string EmpId
    {
        get { return empId; }
        set { empId = value; }
    }

    public string Post
    {
        get { return post; }
        set { post = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public decimal AnnualTaxes
    {
        get { return CalculateAnnualTaxes(); }
    }

    public Employee(string empId, string post, decimal salary)
    {
        this.empId = empId;
        this.post = post;
        this.salary = salary;
    }

    public Employee(string empId, string post)
    {
        this.empId = empId;
        this.post = post;
        this.salary = 0;
    }

    private decimal CalculateAnnualTaxes()
    {
        decimal annualTaxes = salary * 0.15m; // Assuming a tax rate of 15%
        return annualTaxes;
    }
}

class Program
{
    static void Main()
    {
        string empId = "E1001";
        string post = "Manager";
        decimal salary = 50000;

        Employee employee1 = new Employee(empId, post, salary);

        Console.WriteLine("Employee Information:");
        Console.WriteLine("Employee ID: " + employee1.EmpId);
        Console.WriteLine("Post: " + employee1.Post);
        Console.WriteLine("Salary: " + employee1.Salary);
        Console.WriteLine("Annual Taxes: " + employee1.AnnualTaxes);

        Employee employee2 = new Employee("E1002", "Supervisor");

        Console.WriteLine("\nEmployee Information:");
        Console.WriteLine("Employee ID: " + employee2.EmpId);
        Console.WriteLine("Post: " + employee2.Post);
        Console.WriteLine("Salary: " + employee2.Salary);
        Console.WriteLine("Annual Taxes: " + employee2.AnnualTaxes);
    }
}
