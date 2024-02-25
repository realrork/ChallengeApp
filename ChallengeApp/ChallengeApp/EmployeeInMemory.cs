namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {      
        private List<float> grades = new List<float>();

        public EmployeeInMemory()
            : this("John", "Doe", 33, 'N') { }
        public EmployeeInMemory(string firstName, string lastName, int age)
            : this(firstName, lastName, age, 'N') { }
        public EmployeeInMemory(string firstName, string lastName, int age, char sex)
            : base(firstName, lastName, age, sex) 
        {
            base.GradeAdded += EmployeeInMemoryGradeAdded;
        }

        private void EmployeeInMemoryGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("to a list.");
        }

        public override void AddGrade(float score)
        {
            if (score >= 0 && score <= 100)
            {
                grades.Add(score);
            }
            else
            {
                throw new Exception("Score value is out of range!");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.GradesCount = grades.Count;

            if (grades.Count != 0)
            {
                foreach (float grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= statistics.GradesCount;
            }

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
