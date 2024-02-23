namespace ChallengeApp
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        char Sex { get; }
        string EmployeeId { get; }

        Statistics GetStatistics();
        void AddGrade(string score);
        void AddGrade(float score);
        int GetGradesCount();
        
    }
}
