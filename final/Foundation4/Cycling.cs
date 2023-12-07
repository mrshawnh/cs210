using System.IO.Pipes;

public class Cycling : Exercise{

    private double _cyclingSpeed;

    public Cycling(string date, int length, double speed): base(date, length){
        _cyclingSpeed = speed;
        SetExerciseType("Cycling");
    }

    public override double GetDistance()
    {
        double distance = GetSpeed() * GetLength() / 60;
        return distance;
    }
    
    public override double GetSpeed()
    {
        return _cyclingSpeed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return pace;
    }
}