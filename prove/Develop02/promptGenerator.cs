using System.Formats.Tar;

public class promptGenerator{

    public Random randomGenerator = new Random();

    public string[] _prompts = {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? "
    };

    public string generatePrompt(){
        int prompt = randomGenerator.Next(0, _prompts.Length);
        return _prompts[prompt];
    }
}


