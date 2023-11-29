public class Video {
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> Comments = new List<Comment>();

    public Video (string title, string author, int length){
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void addComment(string commentersName, string commentText){
        Comment comment = new Comment(commentersName, commentText);
        Comments.Add(comment);
    }

    public string getVideoDetails(){
        return ($"\"{_title}\" by {_author} (Length: {_lengthInSeconds}s)");
    }

    public int getNumberOfComments(){
        return Comments.Count;
    }

    public List<Comment> GetComments(){
        return Comments;
    }

}