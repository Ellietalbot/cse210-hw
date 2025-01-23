public class Job 
{    public string _jobTitle;
    public string _company;  // Fixed duplicate variable issue
    public int _startYear;
    public int _endYear;

    public void display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}    