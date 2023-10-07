using System;
using System.Net.Http.Headers;
using System.Xml.Serialization;
using System.IO;

DateTime theCurrentTime = DateTime.Now;
promptGenerator pG = new promptGenerator();
Entry e = new Entry();

int _action;

static int mainMenu()
{
    Console.WriteLine("Please select one of the following choice:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    string choice = Console.ReadLine();
    int option = int.Parse(choice);

    return option;
}

e._journalDate = theCurrentTime.ToShortDateString();

Console.WriteLine("Welcome to the journal program!");
Console.WriteLine();

_action = mainMenu();

while (_action != 5){
    if (_action == 1){
        Console.WriteLine();

        e._journalPrompt = pG.generatePrompt();
        Console.Write(e._journalPrompt);
        e._entry = Console.ReadLine();
        Console.Write("Enter your name: ");
        e._signature = Console.ReadLine();
        e.JournalEntry();

        Console.WriteLine();

        _action = mainMenu();
    }
    else if (_action == 2){
        Console.WriteLine();

        e.displayJournal();
        Console.WriteLine();

        _action = mainMenu();
    }
    else if (_action == 3){
        Console.WriteLine();

        e.LoadJournal();

        Console.WriteLine();

        _action = mainMenu();
    }
    else if (_action == 4){
        Console.WriteLine();

        e.SaveJournal();
        
        Console.WriteLine();

        _action = mainMenu();
    }
    else if (_action == 5){
        break;
    }


}
