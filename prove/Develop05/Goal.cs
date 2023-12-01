public class Goal{
    private List<Goal> _goalList = new List<Goal>();
    private int _points = 0;
    private string _goalName;
    private string _goalDescription;
    


    public void DisplayScore(){
        Console.WriteLine($"You have {_points} points.");
    }

    public void SetGoalName(){
        Console.Write("What is your goal? ");
        _goalName = Console.ReadLine();
    }
    public void SetGoalDescription(){
        Console.Write("Describe your goal: ");
        _goalDescription = Console.ReadLine();
    }

    public virtual void GoalCreation(){
        SetGoalName();
    }



}