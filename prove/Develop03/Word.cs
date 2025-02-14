class Word
{
    private string _term;
    private bool _isHidden;

    public Word(string term)

    {
        _term = term;
        _isHidden = false; 
    }

    public void DisplayWord()
    {
        if (_isHidden)
        {
            Console.Write("_".PadRight(_term.Length, '_') + " ");
        }
        else
        {
            Console.Write(_term + " ");
        }
    }

    public void HideWord()
    {
        _isHidden = true; 
    }

    public bool IsHidden()
    {
        return _isHidden; 
    }
}