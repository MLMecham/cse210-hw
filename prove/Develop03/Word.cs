using System.Net;

public class Word
{
    string _word;
    bool _isHidden;
    int _count;

    public Word()
    {
        // _word = word;
        // if (_word == string.Concat(Enumerable.Repeat("-", _word.Length)))
        // {
        //     _isHidden = true;
        // }
        // else if (_word != string.Concat(Enumerable.Repeat("-", _word.Length)))
        // {
        //     _isHidden = false;
        // }

        _word = "";

        _isHidden = false;

        _count = 0;
    }

    public void SetWord(string word)
    {
        _word = word;

        if (_word == string.Concat(Enumerable.Repeat("_", _word.Length)))
        {
            _isHidden = true;
        }
        else 
        {
            _isHidden = false;
        }
    }


    public void HideWord()
    {
        if (_isHidden == true)
        {
            
        }
        else
        {
            _word = string.Concat(Enumerable.Repeat("_", _word.Length));
            _count = _count + 1;
        }
    }
    public string GetWord()
    {
        return _word;
    }
    
}   