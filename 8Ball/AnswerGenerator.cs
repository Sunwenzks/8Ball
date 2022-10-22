using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    internal static class AnswerGenerator
    {
        private static List<string> answers = new List<string>() { "да", "нет","спросите позже", "очень сомнительно", "незнаю" };
 

       public static string GetRandomAnswer()
       {
            Random random = new Random();
            var index = random.Next(answers.Count - 1);
            return answers[index];
       }
    }
}
