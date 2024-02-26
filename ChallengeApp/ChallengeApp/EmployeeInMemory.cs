namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {      
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory()
            : this("John", "Doe", 33, 'N') { }
        public EmployeeInMemory(string firstName, string lastName, int age)
            : this(firstName, lastName, age, 'N') { }
        public EmployeeInMemory(string firstName, string lastName, int age, char sex)
            : base(firstName, lastName, age, sex) 
        {
            GradeAdded += EmployeeInMemoryGradeAdded;
        }

        private void EmployeeInMemoryGradeAdded(object sender, EventArgs args)
        {
            Messages.Succes("A new grade has been saved to a list.");
        }

        public override void AddGrade(float score)
        {
            if (score >= 0 && score <= 100)
            {
                grades.Add(score);
                if (GradeAdded != null)
                {
                    GradeAdded(this, EventArgs.Empty);
                }
            }
            else
            {
                throw new Exception("Score value is out of range!");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics(grades);

            return statistics;
        }
    }
}
