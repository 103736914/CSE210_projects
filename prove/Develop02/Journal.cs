public class Journal
{
    public string Filename;

    public List<Entry> Entries;

    public void LoadFromFile()
    {
        //akd for filename (save as Filename), load file as Entries (with message)
    }

    public void SaveToFile()
    {
        //if there is a Filename, save the file (with message); otherwise, ask for a filename (save as Filename) and save the file (with message)
    }

    public void DisplayFile()
    {
        //run through the entries in file, output each to the screen with formatting
    }

    public void AddEntry()
    {
        //create new Entry named with precise date and time (use to set (.Date)), .BuildEntry
    }
}

