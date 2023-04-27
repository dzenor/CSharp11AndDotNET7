using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Questions 
    {
        public Questions(string text, string answer, string[]? options )
        {
            Text=text??throw new ArgumentNullException(nameof(text));
            Answer=answer??throw new ArgumentNullException(nameof(answer));
            Options=options?? new string[0];
        }

        public string Text {get; private set;}
        public string[] Options { get; private set; }
        public string  Answer { get; private set; }
    }
}
