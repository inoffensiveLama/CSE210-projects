public class Comment {
    private string _commentersName;
    private string _commentText;

    public Comment(string name, string text){
        _commentersName = name;
        _commentText = text;
    }

    public string getCommentInfo(){
        return ($"{_commentersName}: {_commentText}");
    }

}