using System.Globalization;
using System.Text;

public class Words{

    public Random randomGenerator = new Random();

    private string[] _words;

    private int _status;

    private int _progress;

    private bool _bool;

    public void DisplayScripture(string reference, string text){
        Console.WriteLine($"{reference} - {text}");
    }

    public void AddToArray(string text){
        _words = text.Split(" ");
    }

    public void HideWord(){
        int index = randomGenerator.Next(0, _words.Length);
        string randomWord = _words[index];
        System.Text.StringBuilder sb = new StringBuilder(randomWord);
        sb.Clear();
        for (int c = 0; c < randomWord.Length; c++){
            sb.Append("_");
        }
        string newString = sb.ToString();
        randomWord = newString;
        _words[index] = newString;
    }
    
    public void DisplayHiddenScripture(string reference){
        HideWord();
        Console.WriteLine($"{reference} - {String.Join(" ", _words)}");
    }

    public bool Status(){
        _bool = false;
        _status = _words.Count();
        _progress = 0;
        foreach(string word in _words){
            if (word.Substring(0, 0) == "_"){
                _progress++;
            }
        }
        if (_status == _progress){
            _bool = true;
        }
        return _bool;
    }
}
