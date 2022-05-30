namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string MoodAnalys()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                return message;
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}