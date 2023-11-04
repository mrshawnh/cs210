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

        for (int i = 5; i > 0; i--){

            Console.Write(".");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Breathe Out");
        for (int i = 5; i > 0; i--){

            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner();
    }

}