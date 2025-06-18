class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score=0;
    private const string filePath = "goals.txt";


    public GoalManager();
    public void Start(    )
    {
        Console.WriteLine( "welcome to the goal app." );
        Console.WriteLine( "\nMenu Options:" );
        Console.WriteLine("1.Display Player Info");
        Console.WriteLine("2.List Goal Names");
        Console.WriteLine("3.List Goal Details");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Exit");
        Console.WriteLine("Select a choice");
        input =Console.ReadLine();
        
        switch (input)
        {
            case "1":
                DisplayPlayerInfo();
                break;

            case "2":
                ListGoalNames();
                break;

            case "3":
                ListGoalDetaisl();
                break;

            case "4":
                CreatGoal();
                break;

            case "5":
                RecordEvent();
                Console.WriteLine("Exiting Eternal Quest program");
                break;

            default:
                Console.WriteLine("Invalid option");
                break;    
        }

    }
    public void DisplayPlayerInfo()
    {
        _score = 0;
        Console.WriteLine("your current score is" + _score);
    }
    public void ListGoalNames()
    {
        Console.WriteLine($"the current list names of each goal are {_shortName}");
    }
    public void ListGoalDetaisl()
    {
        Console.WriteLine("Current goal names: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" - {goal.GetDetailsString()}");
        }
    }
    public void CreatGoal()
    {
        Console.WriteLine("What is the new type of goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("Enter your answer");
        string choice  = Console.ReadLine();

        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Describe your goal ");
        string description = Console.ReadLine();

        if (choice == "1")
        {
            Goal goal = new SimpleGoal (name, description);
            _goals.Add(goal);
            Console.WriteLine("Simple Goal Created");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter the number of times to complete the goal?");
            int target = int.Parse(Console.ReadLine());

            Goal goal = new CheckListGoal (name, description, target);
            _goals.Add(goal);
            Console.WriteLine("CheckList Goal Created");
        }
        else if (choice =="3")
        {
            //Console.WriteLine("Enter the number of times to complete the goal?");
            Goal goal = new EternalGoal (name, description, points);
            _goals.Add(goal);
            Console.WriteLine("CheckList Goal Created");
        }

        else 
        {
            Console.WriteLine("Invalid choive, check again.");
        }
        
    
    public void RecordEvent()
    {
        Console.WriteLine("Select a number of goals to record");
        for (int i = 0; i <_goals.Count; i ++) 
        {
            Console.WriteLine($"{i+1}.  {_goals[i].Name}");
        }  
        int index = int.Parse(Console.ReadLine()) -1;

        if (index>=0 && index <_goals.Count)
        {
            _goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    public void SaveGoals (List<Goal> _goals)
    {
    using (StreamWriter writer = new StreamWriter (filePath))
    {
        foreach (Goal goal in _goals)
        {
            writer.WriteLine (goal.GetSaveData());
        }    
    }
    Console.WriteLine("Goals saved successfully.");
        }
    

    public void LoadGoals ()
    {
        _goals.Clear();

        if (File.Exists(filePath))
        {
            string [ ] lines = File.ReadAllLines (filePath);
            foreach (string  line in lines)
            {
                Goal goal = GoalFactory.LoadFromData(line);
                _goals.Add(goal);
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
          Console.WriteLine("No saved goals found.");
        }
    }

}