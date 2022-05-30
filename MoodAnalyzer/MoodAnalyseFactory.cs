using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        public static object CreateMoodAnalyse(string className, string contructorName)
        {
            string pattern = @"." + contructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly Execute = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = Execute.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "No Constructor is Found");
            }
        }
    }
}
