class BreathingActivity : Activity
{
    public BreathingActivity():base ("Breathing activity", "It will help you to breath",9)
    {

    }

    public void Run()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("How long you want to complete the exercise?");
        int duration;
        string input = Console.ReadLine();

        while (!int.TryParse(input, out duration))
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }

        ShowSpinner(3);

        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.WriteLine("Breathe In");
            ShowCountDown(4);
            timeElapsed += 4;       
             Console.WriteLine("Breathe out");
            ShowCountDown(4);
             Console.WriteLine("Breathe In");
            ShowCountDown(4);
             Console.WriteLine("Breathe out");
            timeElapsed += 4;
        }
       
        DisplayEndingMessage();
    }
}