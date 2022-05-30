namespace MoodAnalyze
{
    public class MoodAnalyzer
    {
        public string message;

        public MoodAnalyzer()
        {
        }

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (message.Equals(" "))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "message is empty");
                }
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "message is null");
                }

                if (message.ToLower().Contains("happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
            catch (MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "message is null");
            }
            catch (Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "message is empty");
            }

        }
    }
}