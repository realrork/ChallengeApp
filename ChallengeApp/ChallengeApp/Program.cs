﻿using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new EmployeeInFile();

        Console.WriteLine("Witamy w programie ROBOCEN do oceny pracowników firmy.");
        Console.WriteLine("======================================================\n");
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
                Messages.Error(exception.Message);
            }
            finally { }

        }

        var statistics = employee.GetStatistics();

        try
        {
            if (employee.GetType() == typeof(EmployeeInFile))
            {
                Console.WriteLine($"\nZgromadzono łącznie oceny w ilości {statistics.Count}. A oto uzyskane statystyki dla obiektu '{employee.EmployeeId}':");
            }
            else if (employee.GetType() == typeof(EmployeeInMemory))
            {
                Console.WriteLine($"\nWprowadzono oceny w ilości {statistics.Count}. A oto uzyskane statystyki dla obiektu '{employee.EmployeeId}':");
            }
            Console.WriteLine($"Min: {statistics.Min}; Max: {statistics.Max}; Average: {Math.Round(statistics.Average, 4)} with Letter \"{statistics.AverageLetter}\"");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}

