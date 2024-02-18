namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Points = new List<int>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        private List<int> Points { get; set; }

        public int Result
        {
            get
            {
                return this.Points.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.Points.Add(score);
        }

        public void AddScore(int[] scores)
        {
            foreach (int score in scores)
            {
                this.Points.Add(score);
            }            
        }
    }
}
