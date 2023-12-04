using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Reno Convention Center 4590 S Virginia St", "Reno", "Nevada", "USA");

        Lecture lecture = new Lecture("'Extreme Ownership'", "Lessons learned by a Navy Seal Veteran", "December 15, 2023", "5 PM MST", "Lecture",
        address1, "Jocko Willink", 100);

        Address address2 = new Address("13 Temple Dr, Corner Whiteplains Ave, Greenmeadows Subdivision, Ugong Norte 1110", 
        "Quezon City", "Metro Manila", "Philippines");

        Reception reception = new Reception("Shawn's Wedding", "Wedding of Shawn Henrie to the love of his life", "October 12, 2023", "10 AM", "Reception",
        address2, "shawnReception@email.com");

        Address address3 = new Address("Poctoy 4903", "Torrijos", "Marinduque", "Philippines");

        Outdoor outdoor = new Outdoor("Poctoy Beach Party", "Come enjoy the water, food, and company at the wonderful white beach of Poctoy",
        "January 15, 2024", "7 AM", "Outdoor", address3, "Sunny");

        Console.WriteLine($"{lecture.GetEventType()} Event\n");
        lecture.ShortDescription();
        Console.WriteLine();
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.LectureFullDetails();

        Console.WriteLine("-------------");

        Console.WriteLine($"{reception.GetEventType()} Event\n");
        reception.ShortDescription();
        Console.WriteLine();
        reception.StandardDetails();
        Console.WriteLine();
        reception.ReceptionFullDetails();

        Console.WriteLine("-------------");

        Console.WriteLine($"{outdoor.GetEventType()} Event\n");
        outdoor.ShortDescription();
        Console.WriteLine();
        outdoor.StandardDetails();
        Console.WriteLine();
        outdoor.OutdoorFullDetails();
    }
}