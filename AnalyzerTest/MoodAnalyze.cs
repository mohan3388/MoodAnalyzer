

using MoodAnalyzer;
using NUnit.Framework;

namespace AnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnSad()
        {
            MoodAnalyser analyzer = new MoodAnalyser("I am in Sad Mood");
            string actual = analyzer.MoodAnalys();
            Assert.Pass(actual, "Sad");
        }
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnHappy()
        {
            MoodAnalyser analyzer = new MoodAnalyser("I am in Happy Mood");
            string actual = analyzer.MoodAnalys();
            Assert.Pass(actual, "Happy");
        }
    }
}