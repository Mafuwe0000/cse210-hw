class PromptGenerator
{
    List<string> _prompts = new List<string> ();
    public string randomPrompt;

   
     public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What do you want your kids to remember you off?");
        _prompts.Add(" What someone said to you, you loved most?");

    }
    
    public string GetRandomPrompt ()
    {
       
        Random random = new Random ();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine (randomPrompt);
        return randomPrompt;
    }   
}