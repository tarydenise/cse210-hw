using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("42 Black Hat Point", "Vinkus", "Kiamo Ko", "Oz");
        Address address2 = new Address("123 Yellow Brick Road", "Bluestem", "KS", "USA");

        Customer customer1 = new Customer("Elphaba Thropp", address1);
        Customer customer2 = new Customer("Dorothy Gale", address2);

        Product product1 = new Product("Flying Broomstick", "F001", 150.00);
        Product product2 = new Product("Pointy Hat", "F002", 35.00);
        Product product3 = new Product("Green Elixir", "F003", 20.00);
        Product product4 = new Product("Bubble Wand", "G001", 99.99);
        Product product5 = new Product("Silver Slippers", "G002", 250.00);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 1); // Elfie's flying broomstick
        order1.AddProduct(product2, 1); // Elfie's hat
        order1.AddProduct(product3, 2); // Wizard's elixir

        Order order2 = new Order(customer2);
        order2.AddProduct(product4, 1); // Glinda's wand
        order2.AddProduct(product5, 1); // Stolen silver slippers

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}