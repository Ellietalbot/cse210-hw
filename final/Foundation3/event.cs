class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _type;
    protected Address _address;

    public Event(string title, string description, string date, string time, string type, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public void ReturnStandardDetails(){
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_address.GetFullAddress());
    }

    public void ReturnShortDescription(){
        Console.WriteLine("Short Description: ");
        Console.WriteLine($"{_type}: {_title} on {_date}");
    }


}
