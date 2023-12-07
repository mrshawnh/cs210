using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Exercise> exercises = new List<Exercise>();

        Running running = new Running("05 Dec 2023", 30, 4.8);
        Cycling cycling = new Cycling("05 Dec 2023", 30, 5);
        Swimming swimming = new Swimming("05 Dec 2023", 30, 25);

        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);

        foreach (Exercise exercise in exercises){
            Console.WriteLine(exercise.GetSummary());
        }

    }
}