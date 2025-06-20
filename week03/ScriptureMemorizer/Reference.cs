class Reference
{
    //Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Methods or Constructors

    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int chapter, int startVerse, int endVerse )
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    // Functions

    public string GetDisplayText()

    {
        if (_endVerse!=null)
        {
        return $"{_book}{_chapter}.{_verse}{_endVerse}";
        }
        else
        {
            return $"{_book}{_chapter}.{_verse}";
        }
    }

    public override string ToString()
    {
        return $"{_book}{_chapter}.{_verse}{_endVerse}";
    }

}