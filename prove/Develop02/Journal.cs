using System;

public class Journal
{
    public string Filename = "none";

    public List<Entry> Entries = new List<Entry>();

    public void LoadFromFile()
    {
        Console.Clear();
        Console.Write("Please enter the journal filename. (Include the \".txt\")\n>>> ");
        Filename = Console.ReadLine();

        Entries = new List<Entry>();

        string[] journalFileText = System.IO.File.ReadAllLines(Filename);
        foreach(string line in journalFileText)
        {
            Entry newEntry = new Entry();
            
            string[] entryElements = line.Split("||break||");

            newEntry.IDTime = entryElements[0];
            newEntry.Date = entryElements[1];
            newEntry.Prompt = entryElements[2];
            newEntry.EntryText = entryElements[3];
            
            Entries.Add(newEntry);
        }
    }

    public void SaveToFile()
    {
        Console.Clear();
        if (Filename == "none")
        {
            Console.Write("Please enter the journal filename. (End it with \".txt\")\n>>> ");
            Filename = Console.ReadLine();
        }    
        
        using (StreamWriter journalFileText = new StreamWriter(Filename))
        {
            foreach (Entry existingEntry in Entries)
            {
                journalFileText.WriteLine($"{existingEntry.IDTime}||break||{existingEntry.Date}||break||{existingEntry.Prompt}||break||{existingEntry.EntryText}");
            }
        }
    }

    public void DisplayJournal()
    {
        Console.Clear();

        if(Entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty. Consider loading a journal or adding an entry.");
        }

        foreach(Entry pastEntry in Entries)
        {
            // Entry localEntry = pastEntry;
            Console.WriteLine($"Date: {pastEntry.Date}     Prompt: {pastEntry.Prompt}\n> {pastEntry.EntryText}\n");
        }
        
        Console.Write("Press the Enter key to return to the main menu.");
        Console.ReadLine();
    }

    public void AddEntry()
    {
        Entry newEntry = new Entry
            {
                IDTime = DateTime.Now.ToString("yyyyMMdd.HHmmss.fffffff"),
                Date = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            };
        newEntry.BuildEntry();
        Entries.Add(newEntry);
    }
}

