using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Activity activity = new Activity();
        BreathingActivity b = new BreathingActivity();

        void Menu(){
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
        }

        Menu();
        if (option == 1){
            activity.SetActivity("Breathing Activity");
            activity.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            activity.WelcomeMessage();
            b.Breathing(activity.GetTimer());
            activity.EndMessage();


        }
        else if (option == 2){
            activity.SetActivity("Reflection Activity");
            activity.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }
        else if (option == 3){
            activity.SetActivity("Listing Activity");
            activity.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }
        else{
            Console.WriteLine("Thank you for using the Mindfulness Program! Have a nice day.");
        }

        
    }
}