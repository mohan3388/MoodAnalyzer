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
            if (message.ToLower().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return message;
        }
    }
}