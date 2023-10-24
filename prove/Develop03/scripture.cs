public class Scripture{

    private string _scripture;

    public Scripture(){
        _scripture = "";
    }

    public Scripture(string scripture){
        _scripture = scripture;
    }

    public string DisplayText(){
        return _scripture;
    }



}