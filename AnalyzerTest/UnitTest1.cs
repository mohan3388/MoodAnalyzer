

using MoodAnalyzer;
using NUnit.Framework;

namespace AnalyzerTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MoodAnalyser problem = new MoodAnalyser();
            var result = problem.MoodAnalys("I am in Happy Mood");
            Assert.AreEqual(result, "Happy");

        }
    }
}