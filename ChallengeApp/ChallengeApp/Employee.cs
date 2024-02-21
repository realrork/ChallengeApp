namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Employee() { }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }


        public void AddGrade(float score)
        {
            if (score >= 0 && score <= 100)
            {
                grades.Add(score);
            }
            else
            {
                Console.WriteLine($"Grade {score} has invalid value!");
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
                        Console.WriteLine($"Grade '{score}' is not valid grade!");
                        break;
                }
            }
        }

        public int GetGradeCount()
        {
            return grades.Count;
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (float grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            if (grades.Count != 0)
            {
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
