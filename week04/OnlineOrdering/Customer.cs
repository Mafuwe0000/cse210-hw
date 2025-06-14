class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer()
    {}


    public bool CustomerInUSA()
    { 
       return _address.AddressInUSA();
    }

    public override string ToString()
    {
        return $"Customer:{_name} \n Address:{_address}";
    }
}