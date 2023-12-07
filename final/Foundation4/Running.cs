using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

public class Running : Exercise{

    private double _runningDistance;
    public Running(string date, int length, double distance) : base (date, length){
        _runningDistance = distance;
        SetExerciseType("Running");
    }

    public override double GetDistance()
    {
        return _runningDistance;
    }

    public override double GetSpeed()
    {
        double speed = (_runningDistance / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / _runningDistance;
        return pace;
    }

    
    
}