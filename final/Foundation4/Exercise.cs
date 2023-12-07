public abstract class Exercise{
    
    private string _date;
    private int _length;
    private string _exerciseType;
    public Exercise(string date, int length){
        _date = date;
        _length = length;
    }

    public string GetDate(){
        return _date;
    }

    public int GetLength(){
        return _length;
    }

    public void SetExerciseType(string exercise){
        _exerciseType = exercise;
    }
    public string GetExerciseType(){
        return _exerciseType;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary(){
        string summary = $"{GetDate()} {GetExerciseType()} ({GetLength()})- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        return summary;
    }




}