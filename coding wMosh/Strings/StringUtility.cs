using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringUtility
    {
      public  static string SummerizeText(string text, int maxLenght = 20)
        {



            if (text.Length<maxLenght)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLenght)
                    {
                        break;
                    }

                }


                return String.Join(" ", summaryWords) + ".....";


            }
        }
    }
}
