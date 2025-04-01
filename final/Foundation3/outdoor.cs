class OutdoorEvent : Event {
    private string _weatherForecast;

    public OutdoorEvent(string title, string description, string date, string time, string type, Address address, string weatherForecast)
        : base(title, description, date, time, type, address){
        _weatherForecast = weatherForecast;
    }

    public void ReturnFullDetails(){
        ReturnStandardDetails();  
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }
}