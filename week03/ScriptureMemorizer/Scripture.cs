using System;
using System.Collections.Generic;
class Scripture
{
    
    //Variables 
    private Reference _reference;
    public List<Word> _words = new List<Word>();

    // constructors
    public Scripture (Reference Reference, string text)
    {
        _reference = Reference;
        foreach (var word in text.Split(' '))
        {
        _words.Add (new Word(word));
        }
    }


    //Functions
    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random ();
        int hiddenNumber = 0;
        while (hiddenNumber < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                
            _words[index].Hide();
            hiddenNumber ++;
            }
        }
        
             
    }



    public override string ToString()
    {
        return GetDisplayText();
    }

    public string GetDisplayText ()
    {
        List<string> _displayedWords = new List<string>();
        foreach (var word in _words)
        {
            _displayedWords.Add(word.GetDisplayText());
        }
        return _reference.ToString ()+""+string.Join("",_displayedWords);

    }

    public bool isCompletelyHidden()
    {
        foreach (var item in _words)
        {
            if (!item.IsHidden())
            {
                return true;
            }  
        }
        return false;
      
    }
}