using System;

class University
{
    protected string universityName;
    protected int totalStudents;

    public University(string universityName, int totalStudents)
    {
        this.universityName = universityName;
        this.totalStudents = totalStudents;
    }

    public void DisplayUniversityInfo()
    {
        Console.WriteLine("University: " + universityName);
        Console.WriteLine("Total Students: " + totalStudents);
    }
}

class College : University
{
    private string collegeName;
    private int totalEnrollment;

    public College(string universityName, int totalStudents, string collegeName, int totalEnrollment)
        : base(universityName, totalStudents)
    {
        this.collegeName = collegeName;
        this.totalEnrollment = totalEnrollment;
    }

    public void DisplayCollegeInfo()
    {
        DisplayUniversityInfo();
        Console.WriteLine("College: " + collegeName);
        Console.WriteLine("Total Enrollment: " + totalEnrollment);
    }
}

class Program
{
    static void Main()
    {
        string universityName = "ABC University";
        int totalStudents = 5000;
        string collegeName = "XYZ College";
        int totalEnrollment = 1000;

        College college = new College(universityName, totalStudents, collegeName, totalEnrollment);

        college.DisplayCollegeInfo();
    }
}
