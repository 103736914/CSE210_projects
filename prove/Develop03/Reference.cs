class Reference
{
    private string _book;
    private string _chapter;
    private string _verseRange;

    public Reference(string bookInput, string chapterInput, string verseRangeInput)
    {
    _book = bookInput;
    _chapter = chapterInput;
    _verseRange = verseRangeInput;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verseRange}";
    }
}

