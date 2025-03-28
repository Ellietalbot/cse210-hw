class Product
{
    private string _productName;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, double pricePerUnit, int quantity)
    {
        _productName = name;
        _productID = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductID()
    {
        return _productID;
    }


    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}
