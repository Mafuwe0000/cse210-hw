class Comment
{
    string _name;
    List<Comment> _replies = new List<Comment>();


    //Construtor
    public Comment(string name,List<Comment> text)
    {
        _name = name;
        _text= text;
    }

}