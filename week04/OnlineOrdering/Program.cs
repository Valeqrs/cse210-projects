using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);   // USA
            Customer customer2 = new Customer("Jane Smith", address2); // Canada

            // Create order #1 (USA customer)
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", 101, 999.99, 1));
            order1.AddProduct(new Product("Wireless Mouse", 102, 25.50, 2));
            order1.AddProduct(new Product("Mechanical Keyboard", 103, 45.00, 1));

            // Create order #2 (non-USA customer)
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("4K Monitor", 201, 299.99, 2));
            order2.AddProduct(new Product("HDMI Cable", 202, 15.99, 3));

            // Put orders into a list for iteration
            List<Order> orders = new List<Order> { order1, order2 };

            // Display results for each order
            foreach (Order order in orders)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("                  ORDER");
                Console.WriteLine("========================================");

                Console.WriteLine("PACKING LABEL:");
                Console.Write(order.GetPackingLabel());

                Console.WriteLine("SHIPPING LABEL:");
                Console.WriteLine(order.GetShippingLabel());

                // Format total cost with two decimal places
                Console.WriteLine($"TOTAL PRICE: ${order.GetTotalCost():0.00}");

                Console.WriteLine("\n");
            }
        }
    }
}