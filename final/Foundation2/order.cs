class Order
{
    private List<Product> _products;
    private Customer _customer;
    private Address _address;

    public Order(Customer customer, Address address)
    {
        _products = new List<Product>();
        _customer = customer;
        _address = address;
    }


    public void AddProduct(Product product, int quantity)
    {
        product.SetQuantity(quantity);
        _products.Add(product);
    }

    public double ReturnTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_address.IsUSA())
        {
            total += 5; 
        }
        else
        {
            total += 35; 
        }

        return total;
    }

    public void ReturnPackingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductID());
        }
    }

    public void ReturnShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_address.ReturnAddress()}");
    }
}
