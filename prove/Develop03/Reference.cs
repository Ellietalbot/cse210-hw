using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse;  

    public Reference(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public Reference(string book, int chapter, int startingVerse)
        : this(book, chapter, startingVerse, startingVerse) {}

    public void Display()
    {
        if (_startingVerse == _endingVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startingVerse} ");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startingVerse}-{_endingVerse} ");
        }
    }
    public static Reference ParseReference(string input)
    {
        string[] parts = input.Split(' ');
        string book = string.Join(" ", parts, 0, parts.Length - 1);
        string chapterVerse = parts[parts.Length - 1];
        string[] chapterAndVerses = chapterVerse.Split(':');
        int chapter = int.Parse(chapterAndVerses[0]);
        string[] verses = chapterAndVerses[1].Split('-');
        int startVerse = int.Parse(verses[0]);
        int endVerse = verses.Length > 1 ? int.Parse(verses[1]) : startVerse;

        return new Reference(book, chapter, startVerse, endVerse);
    }
}
