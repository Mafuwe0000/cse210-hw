class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;


    public Product()
    {}
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }



    public int GetTotalCost (int pricePerUnity, int quantity)
    {
        int custoTotal =pricePerUnity * quantity;
        return custoTotal;
    }

    public override string ToString()
    {
    return $"Product: {_name}, Product Id {_productId}, Price: {_price}, Quantity:{_quantity}";
    }

}
