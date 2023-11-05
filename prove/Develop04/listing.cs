public class ListingActivity : Activity{

    Random random = new Random();

    private List<string> _lPrompts = new List<string>();

    public void AddListPrompts(){
        _lPrompts.Clear();
        _lPrompts.Add("Who are people that you appreciate?");
        _lPrompts.Add("What are personal strengths of yours?");
        _lPrompts.Add("Who are people that you have helped this week?");
        _lPrompts.Add("When have you felt the Holy Ghost this month?");
        _lPrompts.Add("Who are some of your personal heroes?");
    }

    public void Listing(int time){
        AddListPrompts();
        int listCount = 0;
        
        Console.Clear();
        Console.WriteLine("Get Ready . . .");
        Countdown(5);

        Console.WriteLine();
        Console.WriteLine(GetLPrompt());
        Console.WriteLine();

        Console.WriteLine("List items in ");
        Countdown(5);
        Console.WriteLine("Go!");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime){
            Console.Write("- ");
            Console.ReadLine();
            listCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"The number of items that you have listed is {listCount}.");
    }

    public string GetLPrompt(){
        string prompt = _lPrompts[random.Next(0, _lPrompts.Count - 1)];
        return prompt;
    }
}