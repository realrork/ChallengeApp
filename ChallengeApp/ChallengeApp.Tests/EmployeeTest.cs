namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEnteredNumericalScores_ThenReturnCorrectStatistics()
        {
            var user = new Employee("Jan", "Kowalski", 40);
            user.AddGrade(5);
            user.AddGrade(3.5f);
            user.AddGrade(1.5f);


            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;
            var resultAvg = user.GetStatistics().Average;

            Assert.AreEqual(1.5f, resultMin);
            Assert.AreEqual(5, resultMax);
            Assert.AreEqual(Math.Round(3.3333f, 4), Math.Round(resultAvg, 4));
        }

        [Test]
        public void WhenInsertedLetterScores_ThenReturnCorrectStatistics()
        {
            var user = new Employee();
            user.AddGrade("A");
            user.AddGrade("B");
            user.AddGrade("c");

            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;
            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;


            Assert.AreEqual(80, resultAvg);
            Assert.AreEqual('A', resultLetterAvg);
            Assert.AreEqual(100, resultMax);
            Assert.AreEqual(60, resultMin);
        }

        [Test]
        public void WhenInsertedMixedScores_ThenReturnCorrectStatistics()
        {
            var user = new Employee();
            user.AddGrade("A");
            user.AddGrade(100);
            user.AddGrade("B");
            user.AddGrade("c");
            user.AddGrade(5);
            user.AddGrade("77");

            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;
            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;


            Assert.AreEqual(Math.Round(70.3333f, 4), Math.Round(resultAvg, 4));
            Assert.AreEqual('B', resultLetterAvg);
            Assert.AreEqual(100, resultMax);
            Assert.AreEqual(5, resultMin);
        }

        [Test]
        public void WhenInsertedIncorrectValue_THenExceptionIsThrown()
        {
            var user = new Employee();
            try
            {
                user.AddGrade(666);
                Assert.Fail("An exception not thrown!");
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Score value is out of range!", ex.Message);
            }
            finally { }
        }

        [Test]
        public void WhenInsertedIncorrectScore_THenExceptionIsThrown()
        {
            var user = new Employee();
            try
            {
                user.AddGrade("J");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Score letter is invalid!", ex.Message);
            }
            finally { }
        }
    }
}