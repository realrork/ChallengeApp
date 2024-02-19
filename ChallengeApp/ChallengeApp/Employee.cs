namespace ChallengeApp
{
    public class Employee
    {
        private List<float> Grades = new List<float>();
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        

        public void AddGrade(float score)
        {
            if (score >= 0 && score <= 100)
            {
                Grades.Add(score);
            }
            else
            {
                Console.WriteLine($"Score {score} is invalid input!");
            }
        }

        public void AddGrade(char score)
        {
            if (float.TryParse($"{score}", out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine($"Char '{score}' is not float number!");
            }
        }

        public void AddGrade(double score)
        {
            AddGrade((float)score);
        }

        public void AddGrade(decimal score)
        {
            AddGrade((float)score);
        }

        public void AddGrade(string score)
        {
            if (float.TryParse(score, out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine($"String \"{score}\" is not float number!");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (float grade in Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= Grades.Count;

            return statistics;
        }

    }
}
