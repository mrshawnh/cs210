using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string int_con =  Console.ReadLine();
            number = int.Parse(int_con);
            numbers.Add(number);
        }

        // code for the sum

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Sum: {sum}");

        // code for average

        float avg = ((float)sum) / (numbers.Count - 1);
        Console.WriteLine($"Average: {avg}");

        // code for largest number

        int largest_num = -1;

        foreach (int line in numbers)
        {
            if (line > largest_num){
                largest_num = line;
            }
        }

        Console.WriteLine($"Largest Number: {largest_num}");
    }   


}