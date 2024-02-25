namespace ChallengeApp.Tests
{
    public class EmployeeInFileTests
    {
        [Test]
        public void WhenGetScoresFromFile_ThenReturnCorrectStatistics()
        {
            var user = new EmployeeInFile("Jan", "Kowalski", 40);

            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;
            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;

            Assert.AreEqual(40, resultMin);
            Assert.AreEqual(100, resultMax);
            Assert.AreEqual(70, resultAvg);
            Assert.AreEqual('B', resultLetterAvg);
        }
    }
}