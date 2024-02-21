namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string firstName, string lastName, int age, char sex)
            : base(firstName, lastName, age, sex)
        {
            this.EmployeeId = Guid.NewGuid().ToString();
        }

        public Employee(string firstName, string lastName, int age) : this(firstName, lastName, age, 'N') { }

        public Employee() : this("John", "Doe", 33, 'M') { }

        public string EmployeeId { get; private set; }

        public void AddGrade(float score)
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

        public void AddGrade(string score)
        {

            if (float.TryParse(score, out float result))
            {
                AddGrade(result);
            }
            else
            {
                switch (score)
                {
                    case "a":
                    case "A":
                        AddGrade(100);
                        break;
                    case "b":
                    case "B":
                        AddGrade(80);
                        break;
                    case "c":
                    case "C":
                        AddGrade(60);
                        break;
                    case "d":
                    case "D":
                        AddGrade(40);
                        break;
                    case "e":
                    case "E":
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception("Score letter is invalid!");
                }
            }
        }

        public int GetGradesCount()
        {
            return grades.Count;
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (grades.Count != 0)
            {
                foreach (float grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= grades.Count;
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
