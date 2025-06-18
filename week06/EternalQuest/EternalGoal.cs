class EternalGoal: Goal
{
    
    
    public EternalGoal (string name, string description, string points) :base (name, description, points)
    {
        
    }
    
    
public override void RecordEvent ()
    {
       
            Console.WriteLine ($"Eternal Goal completed");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation ()
    {
        return $"Eternal Goal | {_shortName}|  {_description}|{points}  ";
    }
}