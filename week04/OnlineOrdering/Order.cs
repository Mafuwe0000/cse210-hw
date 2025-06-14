class Order
{

    List<Product> Products = new List<Product>();
    List<Customer> Customer = new List<Customer>();

    public Order()
    {}

    public Order(Customer customer, Product product)
    {
        Products.Add(product);
        Customer.Add(customer);
    }



    public int  GetTotalPrice (int totalCost)
    {
        int shippingCost= ShippingCost();
        int TotalPrice = totalCost + shippingCost;
        return TotalPrice;
    }
    public int ShippingCost ()
    {
        int shippingCost;
        Console.WriteLine("Are you from USA?");
        string answer = Console.ReadLine();
        if (answer == "Yes")
        {
            shippingCost = 3;
        }
        else
        {
            shippingCost =5;
        }

        return shippingCost;
    }
    public string PackingLabel(string name,Product product)
    {
        
        return $"{name},{product}";
    }
    
    public string ShippingLabel (string name, Address address)
    {
       
        return $"{name},{address}";
    }

    public override string ToString()
    {
    return $"Products: {Products}, Customer {Customer}";
    }
}