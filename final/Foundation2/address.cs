class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country == "US" || _country == "USA" || _country == "America" || 
               _country == "United States" || _country == "United States of America";
    }

    public string ReturnAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_country}";
    }
}
