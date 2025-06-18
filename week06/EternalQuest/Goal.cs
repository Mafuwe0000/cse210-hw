public abstract class Goal
{   
    private string _shortName;
    private string _description;
    private string _points;

    public string GetName()
    {
        return shortName;
    }
    public void SetShortName ( string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription ( string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string _points)
    {
        _points= points;
    }

    public Goal (string name, string description, string points)
    {
        _shortName= name;
        _description= description;
        _points= points;
    }
    

    public abstract void  RecordEvent();

    public virtual bool IsComplete()
    {
        return true;
    }
    public virtual string GetDetailsString()
    {
        return $"[   ] {_shortName} - {_description}";
    }
    public abstract string GetStringRepresentation ();
}