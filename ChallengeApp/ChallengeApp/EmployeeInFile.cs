using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile()
            : this("John", "Doe", 33, 'N') { }
        public EmployeeInFile(string firstName, string lastName, int age)
            : this(firstName, lastName, age, 'N') { }
        public EmployeeInFile(string firstName, string lastName, int age, char sex)
            : base(firstName, lastName, age, sex)
        {
            GradeAdded += EmployeeInFileGradeAdded;
        }

        private void EmployeeInFileGradeAdded(object sender, EventArgs args)
        {
            Messages.Succes("A new grade has been saved to a file.");            
        }

        public override void AddGrade(float score)
        {

            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                throw new Exception("Score value is out of range!");
            }

        }

        private List<float> GetGradesFromFile(string fileName)
        {
            List<float> grades = new List<float>();
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
                return grades;
            }
            else
            {
                throw new Exception("File not found!");
            }
        }

        public override Statistics GetStatistics()
        {
            var grades = GetGradesFromFile(fileName);

            var statistics = new Statistics(grades);

            return statistics;
        }
    }
}
