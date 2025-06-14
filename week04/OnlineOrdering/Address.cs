class Address
{
     
private string _streetAddress;
private string _city;
private string _stateOrprovince;
private string _country;



public Address()
{

    }
    public Address(string street,string  city,string stateOrprovince,string country)
    {
        _streetAddress = street;
        _city =city;
    _stateOrprovince = stateOrprovince;
    _country = country; 
    }


    //Get and setters for all attributes
    public string GetStreetAddress ()
    {
        return _streetAddress;
    }
    public void  SetStreetAddress( string Adrress)
    {
        _streetAddress = Adrress;
    }

    public string GetCity ()
    {
        return _city;
    }
    public void  SetCity( string city)
    {
        _city = city;
    }

    public string GetstateOrprovince ()
    {
        return _stateOrprovince;
    }
    public void  SetstateOrprovince( string stateOrprovince)
    {
    _stateOrprovince = stateOrprovince;
    }

    public string GetCountry ()
    {
        return _country;
    }
    public void SetCountry( string Country)
    {
        _country = Country;
    }

    public bool AddressInUSA()
    {
        return _country.ToLower() =="usa";
    }

    public override string ToString()
    {
    return $"Address: {_streetAddress}, city {_city}, Province: {_stateOrprovince}, Country:{_country}";
    }
}