class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string shortName, string description, string points) :base ( _shortName,  _description,  _points)
    {
       IsComplete = false; 
    }


    public override void RecordEvent ()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine ($"$Simple Goal '{_shortName}' completed!");
        }
        else
        {
            Console.WriteLine ($"Simple Goal {_shortName} was already completed");
        }
    }
    public override bool IsComplete();

    public override string GetDetailsString ()
    {
        string checkbox = IsComplete?  "[x]" :  "[  ]";

        return $"{checkbox}  {_shortName}  - {_description}";
    }
    public override string GetStringRepresentation ()
    {
        return $"Simple Goal | {_shortName}|  {_description}|{IsComplete}  ";
    }
}