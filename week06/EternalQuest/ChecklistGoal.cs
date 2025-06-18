class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string shortName, string description, string points, int target, int bonus) :base (shortName, description,  points)
    {
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent ()
    {
        _amountCompleted = 0;
        if (_target<_amountCompleted)
        {
            _target ++;
            Console.WriteLine($"CheckList Goal {shortName} is now complete.");
        }
        else
        {
            Console.WriteLine ($"CheckList Goal {_shortName} has already been completed");
        }
    }

    public override string GetDetailsString ()
    {
        string checkbox = _amountCompleted>=_target ? "[x]" :  "[  ]";

        return $"{checkbox}  {_shortName}  - {_description}bb({_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation ()
    {
        return $"Checklist | {_shortName} | {_description} |{_target}|{_amountCompleted}";
    }
    public override bool IsComplete();
    public override string GetStringRepresentation();
}