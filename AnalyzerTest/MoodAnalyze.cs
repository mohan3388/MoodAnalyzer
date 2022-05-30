

using MoodAnalyzer;
using NUnit.Framework;

namespace AnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnEmpty()
        {
            try
            {
                MoodAnalyser analyzer = new MoodAnalyser("");
                string actual = analyzer.MoodAnalyze();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnNull()
        {
            try
            {
                MoodAnalyser analyzer = new MoodAnalyser(null);
                string actual = analyzer.MoodAnalyze();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "message is Null");
            }
        }
    }
}