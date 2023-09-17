using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

        int guess_num = int.Parse(guess);
        int guess_count = 1;

        while (magic_num != guess_num)
        {

            if (magic_num > guess_num)
            {
                Console.WriteLine("Higher!");
                Console.Write("What is your next guess? ");
                guess = Console.ReadLine();
                guess_num = int.Parse(guess);
                guess_count++;
            }
            if (magic_num < guess_num)
            {
                Console.WriteLine("Lower!");
                Console.Write("What is your next guess? ");
                guess = Console.ReadLine();
                guess_num = int.Parse(guess);
                guess_count++;
            }
            if (magic_num == guess_num)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guess_count} tries to guess the magic number.");
            }
        }

    }
}