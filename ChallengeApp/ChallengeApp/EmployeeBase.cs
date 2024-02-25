namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string firstName, string lastName, int age, char sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            EmployeeId = Guid.NewGuid().ToString();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        public string EmployeeId { get; private set; }


        public abstract void AddGrade(string score);
        public abstract void AddGrade(float score);
        public abstract Statistics GetStatistics();
    }
}
