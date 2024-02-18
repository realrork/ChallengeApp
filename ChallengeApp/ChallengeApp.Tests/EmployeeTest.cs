namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectSum()
        {
            var user = new Employee("Jan", "Kowalski", 33);
            user.AddScore(4);
            user.AddScore(2);
            user.AddScore(10);

            var result = user.Result;

            Assert.AreEqual(16, result);
        }
        [Test]
        public void WhenEmployeeGetScoresArray_ThenReturnCorrectSum()
        {
            var user = new Employee("Jan", "Kowalski", 33);
            user.AddScores([5, 3, 5, 8]);

            var result = user.Result;

            Assert.AreEqual(21, result);
        }

        [Test]
        public void WhenEmployeeGetScoresAndPunishment_ThenReturnCorrectSum()
        {
            var user = new Employee("Jan", "Kowalski", 33);
            user.AddScore(5);
            user.AddScore(10);
            user.AddPunishment(2);
            user.AddPunishment(7);

            var result = user.Result;

            Assert.AreEqual(6, result);

        }
    }
}