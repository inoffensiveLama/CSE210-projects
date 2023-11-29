using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1, 2, 800.23f);
        Product product2 = new Product("Wireless Mouse", 2, 1, 25.76f);
        Product product3 = new Product("Over-ear Headphones", 3, 3, 50.93f);

        Address address1 = new Address("123 Tech Lane", "Tech City", "Techland", "United States");
        Customer customer1 = new Customer("Tech Buyer", address1);

        Address address2 = new Address("456 Gadget Street", "Gadget Town", "Gadgetland", "Canada");
        Customer customer2 = new Customer("Gadget Enthusiast", address2);


        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(order1Products, customer1);

        List<Product> order2Products = new List<Product> { product2, product3 };
        Order order2 = new Order(order2Products, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Price: $" + order1.getTotalPrice());
        Console.WriteLine("Packing Label:\n" + order1.getPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.getShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Price: $" + order2.getTotalPrice());
        Console.WriteLine("Packing Label:\n" + order2.getPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.getShippingLabel());
    }
}