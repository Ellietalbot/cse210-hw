class Reception : Event {
    private string _rvspEmail;

    public Reception(string title, string description, string date, string time, string type, Address address, string rvspEmail) 
        : base(title, description, date, time, type, address){
        _rvspEmail = rvspEmail;
    }

    public void ReturnFullDetails(){
        ReturnStandardDetails();  
        Console.WriteLine($"RSVP Email: {_rvspEmail}");
    }
}