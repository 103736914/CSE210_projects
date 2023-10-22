class Scripture
{
    //A "_reference" property is not present despite the original plan for it to be; the relevant functionality is now in the Program.cs file.
    private List<Word> _words = new List<Word>();
    private List<int> _unhiddenWords = new List<int>();

    //Create the word list using the words in the scripture, add an index number (0, 1, 2, etc.) to the unhidden word list for each word in the word list
    int wordIndex = 0;
    public Scripture(string inputScripture)
    {
        string[] wordsInScripture = inputScripture.Split(" ");
        foreach (string scriptureWord in wordsInScripture)
        {
            Word word = new Word(scriptureWord);
            _words.Add(word);
            _unhiddenWords.Add(wordIndex);
            wordIndex += 1;
        }
    }

    //Tells 3 (max of however many are left) words on the word list to hide & removes the relevant indexe(s) from the unhidden word list.
    public void HideWords()
    {
        for (int count = 0; count < 3; count++)
        {
            if (_unhiddenWords.Count() > 0)
            {
                //Hides random unhidden (according to the unhidden words list) word from the word list and removes its reference on the unhidden words list
                Random indexes = new Random();
                int indexToBeRemoved = indexes.Next(_unhiddenWords.Count());
                _words[_unhiddenWords[indexToBeRemoved]].HideWord();
                _unhiddenWords.RemoveAt(indexToBeRemoved);
            }
        }
    }

    //Allows for checking if the entire scripture is hidden (based on the unhidden words list)
    public bool CheckIfHidden()
    {
        if (_unhiddenWords.Count() != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string GetScripture()
    {
        string returnString = "";
        foreach(Word scriptureWord in _words)
        {
            string word = scriptureWord.GetWord();
            //Don't start with a space
            if (returnString == "")
            {
                returnString = word;
            }
            else
            {
                // returnString = $"{returnString} {word}";
                returnString += $" {word}";
            }
        }
        return returnString;
    }
}

