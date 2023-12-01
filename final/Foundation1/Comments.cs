public class Comments{

    private string _name;
    private string _comment;
    
    public Comments(string name, string comment){
        _name = name;
        _comment = comment;
    }

    public void DisplayComment(){
        Console.WriteLine($"{_name} - {_comment}");
    }
}