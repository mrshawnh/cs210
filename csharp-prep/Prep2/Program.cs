using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int grade_int = int.Parse(grade);

        string letter = "";

        if (grade_int >= 90)
        {
            letter = "A";
        }
        else if (grade_int >= 80 && grade_int < 90)
        {
            letter = "B";
        }
        else if (grade_int >= 70 && grade_int < 80)
        {
            letter = "C";
        }
        else if (grade_int >= 60 && grade_int < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade Letter: {letter}");

        if (grade_int >= 70)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}