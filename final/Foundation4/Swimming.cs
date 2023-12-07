public class Swimming : Exercise{

    double _laps;

    public Swimming(string date, int length, double laps) : base(date, length){
        _laps = laps;
        SetExerciseType("Swimming");
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return pace;
    }
}