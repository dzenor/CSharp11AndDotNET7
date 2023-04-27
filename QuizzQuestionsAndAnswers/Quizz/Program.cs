using Quizz;

QuizzQestions.SetGeographyQuestions();
//bonus da dadete opcija da dadete na userot da odbere kategorija


Console.WriteLine("What type of quizz you want? Footbal or Geography?");
string userOdg = Console.ReadLine();

if (userOdg == "Geography")
{

    foreach (var questions in QuizzQestions.Question)
    {
        Console.WriteLine(questions.Text);

        for (int i = 0; i<questions.Options.Length; i++)
        {
            Console.WriteLine($"{i+1}. {questions.Options[i]}");
        }

        string userAnswer = Console.ReadLine().Trim().ToLower();
        if (userAnswer==questions.Answer)
        {
            Console.WriteLine("You guess right!");
        }
        else
        {
            Console.WriteLine($"You are wrong,the answer was {questions.Answer}");
        }
        Console.WriteLine();
    }
}
else
{
    QuizzQestions.SetFootballQuestions();
    foreach(var prasanja in QuizzQestions.Question)
    {
        Console.WriteLine(prasanja.Text);
        for (int i = 0;i<prasanja.Options.Length;i++)
        {
            Console.WriteLine($"{i+1}. {prasanja.Options[i]}");
        }

        string korisnikOdgovor = Console.ReadLine().Trim().ToLower();
        if (korisnikOdgovor == prasanja.Answer)
        {
            Console.WriteLine("You guess right!");
        }
        else
        {
            Console.WriteLine($"You are wrong,the answer was {prasanja.Answer}");
        }
        Console.WriteLine();




    }
}





bool newGame = Console.ReadLine().ToLower() == "yes";
if (newGame)
{
    //treba da napravite nova igra so druga kategorija
    //primer QuizzQestions.SetHistoryQuestions();

}
