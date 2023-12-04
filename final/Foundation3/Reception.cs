public class Reception : Event{

    private string _RSVP;

    public Reception(string title, string description, string date, string time, string eventType, Address address, string RSVP) : base(
        title, description, date, time, eventType, address
    ){
        _RSVP = RSVP;
    }

    public void ReceptionFullDetails(){
        Console.WriteLine($"You are invited to {GetTitle()}!");
        Console.WriteLine(GetDescription());
        Console.WriteLine($"Which will be held on {GetDate()} @{GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}\n");

        Console.WriteLine($"Reserve your spot by emailing : {_RSVP}");
    }
}  