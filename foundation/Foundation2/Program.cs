using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Unknown St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Mysterious Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Bejamin Hook", address1);
        Customer customer2 = new Customer("Favour Joseph", address2);

        // Create products
        Product product1 = new Product("Widget", "W123", 10.99m, 2);
        Product product2 = new Product("Gadget", "G456", 15.49m, 1);
        Product product3 = new Product("Doohickey", "D789", 7.99m, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}