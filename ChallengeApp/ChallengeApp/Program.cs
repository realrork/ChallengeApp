using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new Employee();

        Console.WriteLine("Witamy w programie ROBOCEN do oceny pracowników.");
        Console.WriteLine("Wprowadzaj kolejne oceny od 1 do 100 lub w postaci");
        Console.WriteLine("liter od A do E. Naciśnięcie 'q' kończy wprowadzanie.");
        Console.WriteLine("=====================================================\n");
        while (true)
        {
            Console.Write("Podaj ocenę pracownika: ");
            var input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            try
            {
                employee.AddGrade(input);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally { }

        }

        var statistics = employee.GetStatistics();
        Console.WriteLine($"\nWprowadzono oceny w ilości {employee.GetGradesCount()}. A oto uzyskane statystyki dla obiektu '{employee.EmployeeId}':");
        Console.WriteLine($"Min: {statistics.Min}; Max: {statistics.Max}; Average: {Math.Round(statistics.Average, 4)} with Letter {statistics.AverageLetter}");
    }
}

