using System.Diagnostics;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEnteredNumericalScores_ThenReturnCorrectStatistics()
        {
            var user = new Employee("Jan", "Kowalski");
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
        public void WhenInsertedInvalidScores_ThenReturnCorrectStatistics()
        {
            var user = new Employee();
            user.AddGrade("J");
            user.AddGrade("A");
            user.AddGrade("B");
            user.AddGrade(".");
            user.AddGrade("C");
            user.AddGrade("C22");
            user.AddGrade(1000);
            user.AddGrade(-100);
            user.AddGrade(20);


            var resultAvg = user.GetStatistics().Average;
            var resultLetterAvg = user.GetStatistics().AverageLetter;
            var resultMin = user.GetStatistics().Min;
            var resultMax = user.GetStatistics().Max;


            Assert.AreEqual(65, resultAvg);
            Assert.AreEqual('B', resultLetterAvg);
            Assert.AreEqual(100, resultMax);
            Assert.AreEqual(20, resultMin);
        }
    }
}