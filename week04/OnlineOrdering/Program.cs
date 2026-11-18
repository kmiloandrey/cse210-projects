using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer ($5 shipping)
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "OR", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Chunky Aroid Potting Mix", "PLT-101", 18.50, 2));
        order1.AddProduct(new Product("Sphagnum Moss Pole", "PLT-204", 14.00, 1));
        order1.AddProduct(new Product("Organic Fertilizer", "PLT-309", 12.25, 3));

        // Order 2: International Customer ($35 shipping)
        Address address2 = new Address("123 Maple Leaf Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Ryan Reynolds", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Brass Plant Mister", "ACC-410", 22.00, 1));
        order2.AddProduct(new Product("Digital Soil Moisture Meter", "ACC-515", 15.50, 2));

        // Display Order 1
        Console.WriteLine("==================================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================\n");

        // Display Order 2
        Console.WriteLine("==================================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================");
    }
}