using System;

class Program
{
    static void Main(string[] args)
    {   
        string _action;
        bool _progress;
        _progress = true;
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Words word = new Words();

        word.DisplayScripture(reference.DisplayReference(), scripture.DisplayText());
        word.AddToArray(scripture.DisplayText());

        Console.Write("Press enter to continue or type 'quit' to finish: ");
        _action = Console.ReadLine();
        

        while(_action != "quit"){
            Console.Clear();
            word.DisplayHiddenScripture(reference.DisplayReference());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            if (_progress == word.Status()){
                break;
            }

            _action = Console.ReadLine();
        }
        


    }
}