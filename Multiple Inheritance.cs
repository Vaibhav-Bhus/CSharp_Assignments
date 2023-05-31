using System;

interface ICustomer
{
    string CustName { get; set; }
    int Age { get; set; }
}

class Bank
{
    protected string bankName;
    protected string branch;

    public Bank(string bankName, string branch)
    {
        this.bankName = bankName;
        this.branch = branch;
    }

    public void DisplayBankInfo()
    {
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("Branch: " + branch);
    }
}

class Account : Bank, ICustomer
{
    private int accountNumber;
    private decimal balance;
    public string CustName { get; set; }
    public int Age { get; set; }

    public Account(string bankName, string branch, int accountNumber, decimal balance, string custName, int age)
        : base(bankName, branch)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        CustName = custName;
        Age = age;
    }

    public void DisplayAccountInfo()
    {
        DisplayBankInfo();
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Customer Name: " + CustName);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        string bankName = "ABC Bank";
        string branch = "XYZ Branch";
        int accountNumber = 123456;
        decimal balance = 5000;
        string custName = "John Doe";
        int age = 30;

        Account account = new Account(bankName, branch, accountNumber, balance, custName, age);

        account.DisplayAccountInfo();
    }
}
