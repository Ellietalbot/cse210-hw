class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Pumpkin Pie", "28sdk8", 7.50, 10);
        Product product2 = new Product("Chocolate Muffin", "3hd93hd", 2.20, 24);
        Product product3 = new Product("Apple Tart", "jdkf9d", 1.80, 36);


        Customer customer1 = new Customer("Ellie Talbot", new Address("123 Oak Tree Ave", "Treeville", "MO", "US"));
        Order order1 = new Order(customer1, new Address("123 Oak Tree Ave", "Treeville", "MO", "US"));

     
        order1.AddProduct(product1, 5); 
        order1.AddProduct(product3, 2); 

        Console.WriteLine("Order 1:");
        order1.ReturnPackingLabel();
        order1.ReturnShippingLabel();
        Console.WriteLine($"Total Cost: ${order1.ReturnTotalCost()}\n");

    
        Customer customer2 = new Customer("Preston Baumgart", new Address("123 Cherry Tree Lane", "Blossom", "GA", "US"));
        Order order2 = new Order(customer2, new Address("123 Cherry Tree Lane", "Blossom", "GA", "US"));

        order2.AddProduct(product2, 10); 
        order2.AddProduct(product3, 3); 

        Console.WriteLine("Order 2:");
        order2.ReturnPackingLabel();
        order2.ReturnShippingLabel();
        Console.WriteLine($"Total Cost: ${order2.ReturnTotalCost()}\n");
    }
}
