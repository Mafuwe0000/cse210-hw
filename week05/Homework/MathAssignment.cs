class MathAssignment : Assignment
{
    private string _textbookSection ="";
    private string _problems = "";

    public MathAssignment (string textbookSection,string topic, string studentName, string problems) :base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} Problems {_problems}";
    }
}