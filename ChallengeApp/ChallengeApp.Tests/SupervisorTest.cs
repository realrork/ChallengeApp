namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void WhenEnteredOneLetterScores_ThenReturnCorrectStatistics()
        {
            var user = new Supervisor("Jan", "Kowalski", 60);
            user.AddGrade("4");
            user.AddGrade("6");
            user.AddGrade("2");


            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;
            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;

            Assert.AreEqual(20, resultMin);
            Assert.AreEqual(100, resultMax);
            Assert.AreEqual(60, resultAvg);
            Assert.AreEqual('4', resultLetterAvg);
        }

        [Test]
        public void WhenInsertedModifiedScores_ThenReturnCorrectStatistics()
        {
            var user = new Supervisor();
            user.AddGrade("-5");
            user.AddGrade("3+");
            user.AddGrade("1+");
            user.AddGrade("4-");

            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;
            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;


            Assert.AreEqual(45, resultAvg);
            Assert.AreEqual('3', resultLetterAvg);
            Assert.AreEqual(75, resultMax);
            Assert.AreEqual(5, resultMin);
        }

        [Test]
        public void WhenInsertedTooLongScore_THenExceptionIsThrown()
        {
            var user = new Supervisor();
            try
            {
                user.AddGrade("433");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Score is too long!", ex.Message);
            }
            finally { }
        }

        [Test]
        public void WhenInsertedScoreNotInRange_THenExceptionIsThrown()
        {
            var user = new Supervisor();
            try
            {
                user.AddGrade("8");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Score value is not in range!", ex.Message);
            }
            finally { }
        }

        [Test]
        public void WhenInsertedInvalidScore_THenExceptionIsThrown()
        {
            var user = new Supervisor();
            try
            {
                user.AddGrade("A");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Score is not a number!", ex.Message);
            }
            finally { }
        }

        [Test]
        public void WhenInsertedInvalidModifiedScore_THenExceptionIsThrown()
        {
            var user = new Supervisor();
            try
            {
                user.AddGrade("*5");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Score is not a valid!", ex.Message);
            }
            finally { }
        }
    }
}