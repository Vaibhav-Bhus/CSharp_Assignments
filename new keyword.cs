using System;

class Country
{
    protected string country_name;
    protected int population;

    public Country(string country_name, int population)
    {
        this.country_name = country_name;
        this.population = population;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Country: " + country_name);
        Console.WriteLine("Population: " + population);
    }
}

class State : Country
{
    protected string state_name;
    protected int population;

    public State(string country_name, int country_population, string state_name, int state_population)
        : base(country_name, country_population)
    {
        this.state_name = state_name;
        this.population = state_population;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("State: " + state_name);
        Console.WriteLine("Population: " + population);
    }
}

class Program
{
    static void Main()
    {
        string country_name = "United States";
        int country_population = 328200000;
        string state_name = "California";
        int state_population = 39538223;

        State state = new State(country_name, country_population, state_name, state_population);

        Console.WriteLine("State Information:");
        state.DisplayInfo();
    }
}
