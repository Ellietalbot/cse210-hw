class Scripture
{
    private List<Word> _verse;
    private int _wordsHidden;
    private Random _random;
    

    public Scripture(string verse)
    {
        _verse = new List<Word>();
        
        
        
        foreach (string word in verse.Split(" "))
        {
            _verse.Add(new Word(word));
        }

        _wordsHidden = 0; 
        _random = new Random();
    }

    public void Display()
    {
        
        foreach (Word word in _verse)
        {
            word.DisplayWord();
        }
        Console.WriteLine();
    }

    public int GetWordCount()
    {
        return _verse.Count; 
    }

    public void HideRandomWord()
    {
        int wordsToHide = 3;
        int wordsHiddenThisRound = 0;
        List<int> alreadyChosenNumbers = new List<int>();

        
        while (wordsHiddenThisRound < wordsToHide && _wordsHidden < GetWordCount())
        {
            int randomIndex;
            do
            {
                randomIndex = _random.Next(0, GetWordCount()); 
            } while (alreadyChosenNumbers.Contains(randomIndex)); 

            alreadyChosenNumbers.Add(randomIndex);

            
            if (!_verse[randomIndex].IsHidden())
            {
                _verse[randomIndex].HideWord();
                _wordsHidden++; 
                wordsHiddenThisRound++; 
            }
        }
    }

    public int GetWordsHidden()
    {
        return _wordsHidden; 
    }
}
