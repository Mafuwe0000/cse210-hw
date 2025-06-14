class Video
{
string _title;
string _author;
float _length;
Comment _comment;

//Constructor
Public Video( string title,string author,string length,string Comment)
{
    _title = title;
    _author =author;
    _length = length;
    _comment = comment;
}


//Functions


public int  NumberOfComments(List<Comment> comments)
{
    return comments.Count;
    
}

}