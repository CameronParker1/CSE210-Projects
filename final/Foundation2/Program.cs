using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new("Bob Johnson", "1234 A Street", "Houston", "Texas", "United States");
        
        List<Product> p1 = new();

        Product product1 = new("Football", 2386, 25, 1);
        Product product2 = new("Football Helmet", 2358, 95, 1);
        Product product3 = new("Mouth Guard", 579, 15, 2);

        p1.Add(product1);
        p1.Add(product2);
        p1.Add(product3);

        Order order1 = new(p1, customer1);

        Console.WriteLine("Here are the items that you have ordered: ");
        Console.WriteLine("");

        order1.GeneratePackingLabel();
        Console.WriteLine("");
        Console.WriteLine($"The total of your order is: {order1.GetTotal()}");
        Console.WriteLine("");
        Console.WriteLine("Ship to: ");
        order1.GenerateShippingLabel();


        Customer customer2 = new("Sally Smith", "4321 B Street", "London", "England", "United Kingdom");
        
        List<Product> p2 = new();

        Product product4 = new("Pickleball Paddle", 7685, 80, 1);
        Product product5 = new("Gym shorts", 4852, 15, 3);
        Product product6 = new("Refillable Bottle", 257, 20, 1);

        p2.Add(product4);
        p2.Add(product5);
        p2.Add(product6);

        Order order2 = new(p2, customer2);

        Console.WriteLine("Here are the items that you have ordered: ");
        Console.WriteLine("");

        order2.GeneratePackingLabel();
        Console.WriteLine("");
        Console.WriteLine($"The total of your order is: {order2.GetTotal()}");
        Console.WriteLine("");
        Console.WriteLine("Ship to: ");
        order2.GenerateShippingLabel();
    }
}