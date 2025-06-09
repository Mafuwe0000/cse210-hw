using System.Threading;

class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
                "Think of a time when you stood up for someone else.",
               "Think of a time when you did something really difficutl.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something tryly selfless."
    };

    List<string> _questions = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity() : base("Reflecting", "Reflect on a meaningful experience",0)
    {

    }

    public void Run()
    {
       
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("How long you want to reflect?");
        string answer = Console.ReadLine();
        int resposta = int.Parse(answer);
        ShowCountDown(resposta);
        DisplayQuestions();
        string answerPrompt = Console.ReadLine();
        Console.WriteLine("Your answer had been saved.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string pompter = GetRandomPrompt();
        Console.WriteLine(pompter);
    }

    public void DisplayQuestions()
    {
        string questioner = GetRandomQuestion();
        Console.WriteLine(questioner);
    }
}