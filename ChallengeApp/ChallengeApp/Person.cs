namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string firstName, string lastName, int age, char sex)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Sex = sex;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
    }
}
