using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Order order1 = new Order(customerName: "John Doe", customerAddress: "123 Main St, NewYork, USA");
        Product product1 = new Product(name: "Widget", id: 1, price: 10.99, quantity: 2);
        Product product2 = new Product(name: "Gadget", id: 2, price: 15.49, quantity: 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customerName: "Jane Smith", customerAddress: "456 Elm St, Ottawa, Canada");
        Product product3 = new Product(name: "Thingamajig", id: 3, price: 7.99, quantity: 3);
        Product product4 = new Product(name: "Doohickey", id: 4, price: 12.49, quantity: 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}