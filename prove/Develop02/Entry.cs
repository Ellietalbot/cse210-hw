using System.ComponentModel.DataAnnotations;

class Entry
{
    // arrtributes
    public string _prompt;
    public string _entryDateTime;
    public string _entryText;

    //behvaior
    public Entry(string prompt, string date, string entry){
        this._prompt = prompt;
        this._entryDateTime = date;
        this._entryText = entry;

    }
    public Entry(string importedLines){
        string[] parts = importedLines.Split("|");
        this._entryDateTime = parts[0];
        this._prompt = parts[1];
        this._entryText = parts[2];

    }

    public void Display()
    {
        Console.WriteLine($"{_entryDateTime} {_prompt} {_entryText}");


    }
        public string DisplayForExport()
    {
        return $"{_entryDateTime} | {_prompt} | {_entryText}";


    }
}