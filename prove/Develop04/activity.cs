public class Activity{

    private string _activityName;
    private string _activityDescription;
    private int _timer;

    public List<string> _spinner = new List<string>();

    public void CreateSpinner(){
        _spinner.Clear();
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
    }

    public void Spinner(){
        int i = 0;
        CreateSpinner();
        DateTime sTime = DateTime.Now;
        DateTime eTime = sTime.AddSeconds(10);

        while (DateTime.Now < eTime){
            string s = _spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _spinner.Count){
                i = 0;
            }
        }
    }

    public void Countdown(int count){
        for (int s = count; s >= 1; s--){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetActivity(string activity){
        _activityName = activity;
    }

    public void SetDescription(string description){
        _activityDescription = description;
    }

    public void WelcomeMessage(){
        Console.Clear();
        
        int time;

        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session? ");
        time = int.Parse(Console.ReadLine());
        _timer = time;

        
    }

    public int GetTimer(){
        return _timer;
    }

    public void EndMessage(){
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_timer} seconds of the {_activityName}.");
    }

    
    
}