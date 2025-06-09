using System.Threading;

class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity. {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank you for using our program. See you soon");
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\"");


    }
    public void ShowCountDown(int seconds)
    {
        /* Console.WriteLine("How long would you like your session to be?");
         string answer = Console.ReadLine();
         int time = int.Parse(answer);
         Thread.Sleep(time);*/
        Console.Write("4");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("1");
    }

}