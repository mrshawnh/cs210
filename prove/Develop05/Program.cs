using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Goal goals = new Goal();

        int option;

        goals.DisplayScore();
        Menu();
        
        Console.WriteLine();
        Console.WriteLine(option);

        if (option == 1){
            goals.GoalCreation();
        }

        if (option == 2){
            
        }


        void Menu(){
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
        }
    }
}