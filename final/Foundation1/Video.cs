using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
public class Video{
    private string _title;
    private string _author;
    private double _length;
    private int _commentCount = 0;
    private List<Comments> _comments = new List<Comments>();
    
    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void VideoInformation(){
        Console.WriteLine($"Video Information: Title - {_title}, Author - {_author}, Length - {_length}\n");
    }

    public void ShowComments(){
        Console.WriteLine($"Comment count : {_commentCount}\n");

        foreach(Comments comment in _comments){
            comment.DisplayComment();
        }
    }

    public void AddComment(Comments comment){
        _comments.Add(comment);
        _commentCount ++;
    }
}

