using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public static class QuizzQestions
    {
        public static Questions[] Question { get; private set; }

        public static void SetGeographyQuestions()
        {
            Question = new Questions[]
            {
                new Questions("What is the name of the tallest mountain in the world?",
                "Mount Everest",
                new string[]{"Himalayas","Alpes","Vodno","Mount Everest"}),
                new Questions("Whats the biggest continent of the world","Asia",null)

            };
        }

        public static void SetFootballQuestions() {

            Question = new Questions[]
            {
                new Questions("Where messi play football?","PSG",new string[]{"Barcelona","Sevila","PSG"}),
                new Questions("Who is the best player in world?","Messi",null)
            };
        }
    }
}
