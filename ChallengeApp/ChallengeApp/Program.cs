using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new Employee("Dominik", "Jakiśtam");
        employee.AddGrade(2);
        employee.AddGrades([2, 5, 3]);
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min}; Max: {statistics.Max}; Average: {statistics.Average:N4}");
    }
}

