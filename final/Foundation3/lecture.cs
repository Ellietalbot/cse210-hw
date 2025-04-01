class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string type, Address address, string speaker, int capacity) 
        : base(title, description, date, time, type, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    public void ReturnFullDetails(){
        ReturnStandardDetails(); 
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}