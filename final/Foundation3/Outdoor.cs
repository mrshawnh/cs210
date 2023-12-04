public class Outdoor : Event{

    private string _forecast;

    public Outdoor(string title, string description, string date, string time, string eventType, Address address, string forecast) : base(
        title, description, date, time, eventType, address
    ){
        _forecast = forecast;
    }

    public void OutdoorFullDetails(){
        Console.WriteLine($"You are invited to {GetTitle()}!");
        Console.WriteLine(GetDescription());
        Console.WriteLine($"Which will be held on {GetDate()} @{GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}\n");

        Console.WriteLine($"Weather Forecast: {_forecast}");
    }
}