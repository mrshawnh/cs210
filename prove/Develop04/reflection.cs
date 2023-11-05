public class ReflectionActivity : Activity{

    Random random = new Random();

    private List<string> _rprompts = new List<string>();
    private List<string> _questions = new List<string>();

    public void AddPrompts(){

        _rprompts.Clear();

        _rprompts.Add("Think of a time when you stood up for someone else.");
        _rprompts.Add("Think of a time when you did something really difficult.");
        _rprompts.Add("Think of a time when you helped someone in need.");
        _rprompts.Add("Think of a time when you did something truly selfless.");
    }

    public void AddQuestions(){

        _questions.Clear();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Reflection(int time){
        Console.Clear();

        AddPrompts();
        AddQuestions();

        Console.WriteLine("Get Ready . . .");
        Spinner();
        Console.WriteLine();

        Console.WriteLine(GetPrompt());
        Spinner();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime){

            Console.WriteLine();
            Console.WriteLine(GetQuestion());
            Spinner();
        }
    }

    public string GetPrompt(){
        
        string prompt = _rprompts[random.Next(0, _rprompts.Count - 1)];
        return prompt;
    }

    public string GetQuestion(){
        string question = _questions[random.Next(0, _questions.Count - 1)];
        return question;
    }
}