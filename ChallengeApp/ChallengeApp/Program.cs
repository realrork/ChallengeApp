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
        employee.AddGrade("100");

        var statisticsWFE = employee.GetStatisticsWithForEach();
        Console.WriteLine("Statystki wygenerowane przy pomocy pętli Foreach");
        Console.WriteLine($"Min: {statisticsWFE.Min}; Max: {statisticsWFE.Max}; Average: {Math.Round(statisticsWFE.Average,4)}\n");

        var statisticsWF = employee.GetStatisticsWithFor();
        Console.WriteLine("Statystki wygenerowane przy pomocy pętli For");
        Console.WriteLine($"Min: {statisticsWF.Min}; Max: {statisticsWF.Max}; Average: {Math.Round(statisticsWF.Average, 4)}\n");

        var statisticsWDW = employee.GetStatisticsWithDoWhile();
        Console.WriteLine("Statystki wygenerowane przy pomocy pętli DoWhile");
        Console.WriteLine($"Min: {statisticsWDW.Min}; Max: {statisticsWDW.Max}; Average: {Math.Round(statisticsWDW.Average, 4)}\n");

        var statisticsWW = employee.GetStatisticsWithWhile();
        Console.WriteLine("Statystki wygenerowane przy pomocy pętli While");
        Console.WriteLine($"Min: {statisticsWW.Min}; Max: {statisticsWW.Max}; Average: {Math.Round(statisticsWW.Average, 4)}");
    }
}

