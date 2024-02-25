using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile()
            : this("John", "Doe", 33, 'N') { }
        public EmployeeInFile(string firstName, string lastName, int age)
            : this(firstName, lastName, age, 'N') { }
        public EmployeeInFile(string firstName, string lastName, int age, char sex)
            : base(firstName, lastName, age, sex) 
        {
            base.GradeAdded += EmployeeInFileGradeAdded;
        }

        private void EmployeeInFileGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("to a file.");
        }

        public override void AddGrade(float score)
        {

            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
            }
            else
            {
                throw new Exception("Score value is out of range!");
            }
            
        }    
        
        public override Statistics GetStatistics()
        {
            List<float> grades = new List<float>();
            var statistics = new Statistics();                   

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {                        
                        if (float.TryParse(line, out float result))
                        {
                            grades.Add(result);
                        }
                        else
                        {
                            throw new Exception("Bad value. File seems corrupted!");
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("File not found!");
            }

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
