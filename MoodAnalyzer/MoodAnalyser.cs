namespace MoodAnalyzer
{
    public class MoodAnalyser
    {

        public string MoodAnalys(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}