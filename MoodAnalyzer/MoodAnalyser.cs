namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser()
        {
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (message.Equals(" "))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "message is empty");
                }
                if (message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "message is null");
                }
                if (message.ToLower().Contains("Happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "message is null");
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "message is empty");
            }

        }
    }
}
