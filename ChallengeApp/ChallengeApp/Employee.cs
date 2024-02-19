namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grades = new List<float>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private List<float> Grades { get; set; }

        public void AddGrade(float score)
        {
            this.Grades.Add(score);
        }

        public void AddGrades(float[] scores)
        {
            foreach (float score in scores)
            {
                this.Grades.Add(score);
            }            
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(float grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.Grades.Count;

            return statistics;
        }
        
    }
}
