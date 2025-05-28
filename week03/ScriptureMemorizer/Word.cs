class Word
{
    //Variables
    private string _text;
    private bool _isHidden;

    //Constructor or Methods
    public Word(string text)
    {
        _text = text;
    }

    //Functions
    public void Hide()
    {
        _isHidden = true; 
    }

    public void Show ()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText ()
    {
        return _isHidden ? "_":_text;
    }
}