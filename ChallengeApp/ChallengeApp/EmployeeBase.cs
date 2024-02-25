namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public virtual event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string firstName, string lastName, int age, char sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            EmployeeId = Guid.NewGuid().ToString();
            GradeAdded += EmployeeBaseGradeAdded;
        }

        private void EmployeeBaseGradeAdded(object sender, EventArgs args)
        {
            Console.Write("A new grade has been saved ");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        public string EmployeeId { get; private set; }


        public virtual void AddGrade(string score)
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
            if (GradeAdded != null)
            {
                GradeAdded(this, EventArgs.Empty);
            }
        }
        public abstract void AddGrade(float score);
        public abstract Statistics GetStatistics();
    }
}
