class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>
    {

    "Who are people that you appreciate?",
    "What are personal strenghts of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };


    public ListingActivity():base ("Listing","This activity will help you to list all the blessings you had", 10)
    {

    }

    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        GetRandomPrompt();
        ShowCountDown(_count);
         DisplayEndingMessage();
    }

    public void GetRandomPrompt ()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine (_prompts[index]);
    }

    public string GetListFromUser(string List)
    {
        List<string> ListFromUser = new List<string>();
        string Resposta = Console.ReadLine();
        return Resposta;

    }
}