public class Event{

    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    private string _address;

    public Event(string title, string description, string date, string time, string eventType, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address.FullAddress();
    }

    public void StandardDetails(){
        Console.WriteLine($"You are invited to {_title}!");
        Console.WriteLine(_description);
        Console.WriteLine($"Which will be held on {_date} @{_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void ShortDescription(){
        Console.WriteLine($"{_eventType}: {_title}");
        Console.WriteLine(_date);
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetDate(){
        return _date;
    }

    public string GetTime(){
        return _time;
    }

    public string GetEventType(){
        return _eventType;
    }

    public string GetAddress(){
        return _address;
    }
}