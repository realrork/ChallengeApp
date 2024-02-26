//using static ChallengeApp.EmployeeBase;

//namespace ChallengeApp
//{
//    public class Supervisor : IEmployee
//    {
//        private List<float> grades = new List<float>();
//        public  event GradeAddedDelegate GradeAdded;

//        public Supervisor(string firstName, string lastName, int age, char sex)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//            Sex = sex;
//            EmployeeId = Guid.NewGuid().ToString();
//            GradeAdded += SupervisorGradeAdded;
//        }

//        public Supervisor(string firstName, string lastName, int age) : this(firstName, lastName, age, 'N') { }

//        public Supervisor() : this("John", "Doe", 33, 'M') { }

//        public string EmployeeId { get; private set; }
//        public string FirstName { get; private set; }
//        public string LastName { get; private set; }
//        public int Age { get; private set; }
//        public char Sex { get; private set; }

//        private void SupervisorGradeAdded(object sender, EventArgs args)
//        {
//            Console.WriteLine("\"A new supervisor grade has been saved to a list.");
//        }

//        private void AddSupervisorGrade(char score, char sign = ' ')
//        {
//            int modifier = 0;

//            if (sign == '+' && score != '6')
//            {
//                modifier = 5;
//            }
//            else if (sign == '-' && score != '1')
//            {
//                modifier = -5;
//            }

//            switch (score)
//            {
//                case '6':
//                    AddGrade(100 + modifier);
//                    break;
//                case '5':
//                    AddGrade(80 + modifier);
//                    break;
//                case '4':
//                    AddGrade(60 + modifier);
//                    break;
//                case '3':
//                    AddGrade(40 + modifier);
//                    break;
//                case '2':
//                    AddGrade(20 + modifier);
//                    break;
//                case '1':
//                    AddGrade(0 + modifier);
//                    break;
//                default:
//                    throw new Exception("Score value is not in range!");
//            }
//        }

//        public void AddGrade(string score)
//        {
//            if (score.Length > 2)
//            {
//                throw new Exception("Score is too long!");
//            }
//            else if (score.Length == 1)
//            {
//                if (float.TryParse(score, out float result))
//                {
//                    AddSupervisorGrade(score[0]);
//                }
//                else
//                {
//                    throw new Exception("Score is not a number!");
//                }
//            }
//            else if (score.Length == 2)
//            {
//                if (score[0] == '-' && Char.IsDigit(score[1]))
//                {
//                    AddSupervisorGrade(score[1], '-');
//                } else if (score[0] == '+' && Char.IsDigit(score[1]))
//                {
//                    AddSupervisorGrade(score[1], '+');
//                }
//                else if (score[1] == '-' && Char.IsDigit(score[0]))
//                {
//                    AddSupervisorGrade(score[0], '-');
//                }
//                else if (score[1] == '+' && Char.IsDigit(score[0]))
//                {
//                    AddSupervisorGrade(score[0], '+');
//                } else
//                {
//                    throw new Exception("Score is not a valid!");
//                }
//            }
//        }

//        public void AddGrade(float score)
//        {
//            if (score >= 0 && score <= 100)
//            {
//                grades.Add(score);
//            }
//            else
//            {
//                throw new Exception("Score value is out of range!");
//            }
//        }

//        public int GetGradesCount()
//        {
//            return grades.Count;
//        }

//        public Statistics GetStatistics()
//        {
//            var statistics = new Statistics();
//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            if (grades.Count != 0)
//            {
//                foreach (float grade in grades)
//                {
//                    statistics.Max = Math.Max(statistics.Max, grade);
//                    statistics.Min = Math.Min(statistics.Min, grade);
//                    statistics.Average += grade;
//                }

//                statistics.Average /= grades.Count;
//            }

//            switch (statistics.Average)
//            {
//                case var average when average >= 90:
//                    statistics.AverageLetter = '6';
//                    break;
//                case var average when average >= 80:
//                    statistics.AverageLetter = '5';
//                    break;
//                case var average when average >= 60:
//                    statistics.AverageLetter = '4';
//                    break;
//                case var average when average >= 40:
//                    statistics.AverageLetter = '3';
//                    break;
//                case var average when average >= 20:
//                    statistics.AverageLetter = '2';
//                    break;
//                default:
//                    statistics.AverageLetter = '1';
//                    break;
//            }

//            return statistics;
//        }
//    }
//}
