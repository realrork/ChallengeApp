namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectMin()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(1.8f);
            user.AddGrade(0.1f);
            user.AddGrade(2);
            user.AddGrade(8);


            var result = user.GetStatistics().Min;

            Assert.AreEqual(0.1f, result);
        }

        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectMax()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrades([3.5f, 4.5f, 9, 9.9f]);


            var result = user.GetStatistics().Max;

            Assert.AreEqual(9.9f, result);
        }

        [Test]
        public void WhenEmployeeGetScores_ThenReturnIncorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrades([5, 2, 3]);

            var result = user.GetStatistics().Average;

            Assert.AreNotEqual(3.333f, result);
        }

        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrades([5.4f, 2.3f, 6.9f, 2.3f]);

            var result = user.GetStatistics().Average;

            Assert.AreEqual(4.225f, result);
        }
    }
}