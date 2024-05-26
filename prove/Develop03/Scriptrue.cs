public class Scripture
{

    public string _verse;
    public List<string> _verseList;

    public int _randomIndex;
    public string _randomWord;

    public Scripture(string verse)
    {
        _verse = verse;
    
        _verseList =  new List<string>(verse.Split(' '));
    }

    // This code will turn the edited list into a string so 
    // that it may be displayed
    public void SetVerse()
    {
        _verse = string.Join(" ", _verseList);
    }
    
    public void SetRandom()
    {
        Random random = new();
        _randomIndex = random.Next(_verseList.Count());

        _randomWord = _verseList[_randomIndex];
    }
    // Checks if SetRandom works. It does :)
    // public void DisplayRandom()
    // {
    //     Console.WriteLine(_randomIndex + _randomWord);
    // }

    public string GetRandomWord()
    {
        return _randomWord;
    }

    public void SetRandomWord(string word)
    {
        _randomWord = word;
        
    }
    public void ReturnHiddenWord()
    {

        _verseList.Insert(_randomIndex, _randomWord);
        
    }

    public void Dispaly()
    {
        Console.WriteLine(_verse);
    }

    public void DisplayList()
    {
        foreach (string word in _verseList)
        {
            Console.WriteLine(word);
        }
    }

}