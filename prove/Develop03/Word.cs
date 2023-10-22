class Word
{
    private string _word;
    private string _hiddenWord;
    private bool _isHidden = false;

    //Set word and hidden word
    public Word(string inputWord)
    {
        _word = inputWord;

        //Make the hidden word be an number of underscores equal to the number of letters in the word 
        _hiddenWord = "";
        char[] lettersInWord = inputWord.ToCharArray();
        foreach (char letter in lettersInWord)
        {
            _hiddenWord += "_";
        }
    }

    //Mark that the word is hidden for when GetWord() is called
    public void HideWord()
    {
        _isHidden = true;
    }

    //Returns either the word or its hidden variant
    public string GetWord()
    {
        if (_isHidden)
        {
            return _hiddenWord;
        }
        else
        {
            return _word;
        }
    }
}

