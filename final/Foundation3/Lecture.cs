using System.IO.Compression;

public class Lecture : Event{

    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string eventType, Address address, string speaker, int capacity) : base(
        title, description, date, time, eventType, address
    ){
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureFullDetails(){
        Console.WriteLine($"You are invited to {GetTitle()}!");
        Console.WriteLine(GetDescription());
        Console.WriteLine($"Which will be held on {GetDate()} @{GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}\n");

        Console.WriteLine("With our special guest speaker!");
        Console.WriteLine(_speaker);
        Console.WriteLine($"Be early, limited capacity of {_capacity}");
    }

}