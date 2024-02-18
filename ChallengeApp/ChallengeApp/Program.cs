using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee("Jan", "Kowalski", 33);
        Employee employee2 = new Employee("Zbigniew", "Nowak", 49);
        Employee employee3 = new Employee("Zbyszko", "Zawisza", 41);

        employee1.AddScore([6, 5, 6, 9, 10]);

        employee2.AddScore([8, 2, 4, 9, 8]);

        employee3.AddScore(6);
        employee3.AddScore(5);
        employee3.AddScore(2);
        employee3.AddScore(10);
        employee3.AddScore(7);

        List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };
        int bestScore = 0;
        Employee? bestEmployee = null;

        foreach (var employee in employees)
        {
            if (employee.Result > bestScore)
            {
                bestScore = employee.Result;
                bestEmployee = employee;
            }
        }

        Console.WriteLine($"Najlepszy pracownik to {bestEmployee.FirstName} {bestEmployee.LastName}, który w wieku {bestEmployee.Age} lat ma już {bestScore} punktów!");
    }
}

