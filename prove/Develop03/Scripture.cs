using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // add more code
    }

    public void HideRandomWords(int numberToHide)
    {
        // placeholder
    }

    public string GetDisplayText()
    {
        return ""; // 
    }

    public bool IsCompletelyHidden()
    {
        return false; //
    }
}