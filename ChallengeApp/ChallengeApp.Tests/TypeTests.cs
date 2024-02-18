namespace ChallengeApp.Tests
{    
    public class TypeTests
    {
        [Test]
        public void WhenComparingTwoObjects_ThenTheyAreNotEqual()
        {
            var user1 = GetEmployee("Jan", "Kowalski", 33);
            var user2 = GetEmployee("Jan", "Kowalski", 33);

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void WhenComparingTwoValuesOfObjects_ThenTheyAreEqual()
        {
            var user1 = GetEmployee("Jan", "Kowalski", 33);
            var user2 = GetEmployee("Jan", "Kowalski", 33);

            Assert.AreEqual(user1.LastName, user2.LastName);
        }

        [Test]
        public void WhenComparingTwoValues_ThenTheyAreEqual()
        {
            int number1 = 2;
            int number2 = 2;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparingTwoStrings_ThenTheyAreEqual()
        {
            string name1 = "Dominik";
            string name2 = "Dominik";

            Assert.AreEqual(name1, name2);
        }

        private Employee GetEmployee(string firstName, string lastName, int age)
        {
            return new Employee(firstName, lastName, age);
        }
    }
}
