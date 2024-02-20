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
            user.AddGrade("71");
            user.AddGrade(2d);
            user.AddGrade('8');


            var result = user.GetStatisticsWithForEach().Min;

            Assert.AreEqual(0.1f, result);
        }

        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectMax()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(1.8f);
            user.AddGrade(0.1f);
            user.AddGrade("71");
            user.AddGrade(2d);
            user.AddGrade('8');

            var result = user.GetStatisticsWithForEach().Max;

            Assert.AreEqual(71f, result);
        }

        [Test]
        public void WhenEmployeeGetScores_ThenReturnCorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(2f);
            user.AddGrade(3m);
            user.AddGrade('5');
            
            var result = user.GetStatisticsWithForEach().Average;

            Assert.AreEqual(Math.Round(3.3333f,4), Math.Round(result,4));
        }

        [Test]
        public void WhenUsingForLoop_ThenReturnCorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(2f);
            user.AddGrade(3m);
            user.AddGrade('5');

            var result = user.GetStatisticsWithFor().Average;

            Assert.AreEqual(Math.Round(3.3333f, 4), Math.Round(result, 4));
        }

        [Test]
        public void WhenUsingDoWhileLoop_ThenReturnCorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(2f);
            user.AddGrade(3m);
            user.AddGrade('5');

            var result = user.GetStatisticsWithDoWhile().Average;

            Assert.AreEqual(Math.Round(3.3333f, 4), Math.Round(result, 4));
        }

        [Test]
        public void WhenUsingWhileLoop_ThenReturnCorrectAverage()
        {
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(2f);
            user.AddGrade(3m);
            user.AddGrade('5');

            var result = user.GetStatisticsWithWhile().Average;

            Assert.AreEqual(Math.Round(3.3333f, 4), Math.Round(result, 4));
        }
    }
}