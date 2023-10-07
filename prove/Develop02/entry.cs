public class Entry{

    

    public string _journalDate;
    public string _entry;
    public string _journalPrompt;

    public string _signature;

    public List<string> _entries = new List<string>();

    public void displayJournal(){
        foreach (string entry in _entries) {
            Console.WriteLine(entry);
        }
    }
    public void JournalEntry(){
        _entries.Add($"{_journalDate} - {_journalPrompt}- {_entry}, {_signature}");
    }

    public void LoadJournal(){
        string fileName;
        Console.Write("Enter the filename: ");
        fileName = Console.ReadLine();
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines){
            _entries.Add(line);
        }

    }
    public void SaveJournal(){
    string fileName;
    Console.Write("Enter new file name: ");
    fileName = Console.ReadLine();

    using(StreamWriter outputFile = new StreamWriter(fileName)){
        foreach (string line in _entries){
            outputFile.WriteLine(line);
        }
    }
    }

}