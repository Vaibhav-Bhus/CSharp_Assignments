using System;

class Student
{
    private string regNo;
    private string name;
    private DateTime dob;

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime DOB
    {
        get { return dob; }
        set { dob = value; }
    }

    public int Age
    {
        get { return CalculateAge(); }
    }

    public Student(string regNo, string name, DateTime dob)
    {
        this.regNo = regNo;
        this.name = name;
        this.dob = dob;
    }

    private int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dob.Year;

        if (today < dob.AddYears(age))
        {
            age--;
        }

        return age;
    }
}

class Program
{
    static void Main()
    {
        string regNo = "2021001";
        string name = "Sachin Tendulkar";
        DateTime dob = new DateTime(2000, 1, 1);

        Student student = new Student(regNo, name, dob);

        Console.WriteLine("Student Information:");
        Console.WriteLine("Registration Number: " + student.RegNo);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Date of Birth: " + student.DOB.ToShortDateString());
        Console.WriteLine("Age: " + student.Age);
    }
}
