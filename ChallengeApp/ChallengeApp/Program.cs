using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new Employee("Dominik", "Jakiśtam");
        employee.AddGrade(5.5);
        employee.AddGrade(7.7f);
        employee.AddGrade(3.4m);
        employee.AddGrade('9');
        employee.AddGrade('A');
        employee.AddGrade("19a");
        employee.AddGrade("100");
        employee.AddGrade("191");
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min}; Max: {statistics.Max}; Average: {Math.Round(statistics.Average,4)}");
    }
}

