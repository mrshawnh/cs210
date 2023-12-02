using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Customer customer1 = new Customer("John Wick");
        Address address1 = new Address("3690 S Heritage Ave", "Boise", "ID", "USA");

        Product pencil = new Product("Killer pencil", "PL001", 1, 15);
        Product shoes = new Product("Black Leather Shoes","SH002", 3, 50.75);
        Product bag = new Product("Travel Bag", "TB003", 2, 100);

        order1.AddProduct(pencil);
        order1.AddProduct(shoes);
        order1.AddProduct(bag);

        Console.WriteLine("Order #1");
        order1.CalculateFinalPrice(address1);
        Console.WriteLine();
        order1.ShippingLabel(customer1, address1);
        Console.WriteLine();
        order1.PackingLabel();

        Order order2 = new Order();
        Customer customer2 = new Customer("James Bond");
        Address address2 = new Address("85 Albert Embankment", "London", "England", "UK");

        Product wine = new Product("Red Wine", "RW004", 1, 20000);
        Product gun = new Product("Silencer Pistol", "SP005", 2, 1000);
        
        order2.AddProduct(wine);
        order2.AddProduct(gun);

        Console.WriteLine();
        Console.WriteLine("Order #2");
        order2.CalculateFinalPrice(address2);
        Console.WriteLine();
        order2.ShippingLabel(customer2, address2);
        Console.WriteLine();
        order2.PackingLabel();
    }
}