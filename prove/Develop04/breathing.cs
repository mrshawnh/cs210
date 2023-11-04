public class BreathingActivity: Activity{

    public void Breathing(int time){      

        Console.Clear();

        Console.WriteLine("Get ready . . .");
        Spinner();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime){
        
        Console.WriteLine();
        Console.WriteLine("Breathe In");

        Countdown(5);
        
        Console.WriteLine();

        Console.WriteLine("Breathe Out");

        Countdown(5);
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner();
    }

}