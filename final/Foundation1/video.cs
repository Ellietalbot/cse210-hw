using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>(); 
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Posted by {_author}");
        Console.WriteLine($"{_seconds} seconds");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}");
            Console.WriteLine($"{comment.GetText()}");
        }
        Console.WriteLine();
    }

}