using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);
        DisplayResult(userName, squareNumber);
        
        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favNum = int.Parse(number);

            return favNum;
        }

        static int SquareNumber(int number)
        {
            int squ = number * number;

            return squ;
        }

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squareNumber}.");
        }






        
    }
}