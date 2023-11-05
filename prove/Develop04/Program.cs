using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        int option = 0;
        int breathingUsage = 0;
        int reflectUsage = 0;
        int listUsage = 0;

        BreathingActivity b = new BreathingActivity();
        ReflectionActivity r = new ReflectionActivity();
        ListingActivity l = new ListingActivity();

        void Menu(){
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Check activity usage stats");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
        }

        Menu();

        while (option != 5){
        if (option == 1){
            b.SetActivity("Breathing Activity");
            b.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            b.WelcomeMessage();
            b.Breathing(b.GetTimer());
            b.EndMessage();
            breathingUsage++;
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }
        else if (option == 2){
            r.SetActivity("Reflection Activity");
            r.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            r.WelcomeMessage();
            r.Reflection(r.GetTimer());
            r.EndMessage();
            reflectUsage++;
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }
        else if (option == 3){
            l.SetActivity("Listing Activity");
            l.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            l.WelcomeMessage();
            l.Listing(l.GetTimer());
            l.EndMessage();
            listUsage++;
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }
        else if (option == 4){
            Console.WriteLine();
            Console.WriteLine("Mindfulness Program Activity Usage:");
            Console.WriteLine($"Breathing Activity: {breathingUsage}");
            Console.WriteLine($"Reflection Activity: {reflectUsage}");
            Console.WriteLine($"Listing Activity: {listUsage}");
            Thread.Sleep(10000);
            Console.WriteLine();
            Menu();
        }
        }

        if (option == 5){
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Mindfulness Program! Have a nice day.");
        }  
    }
}