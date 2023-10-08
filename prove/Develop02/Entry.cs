public class Entry
{
    public string IDTime;

    public string Date;

    public string Prompt;

    public string EntryText;

    List<string> promptList = new List<string>
    {
        // "Why is the sky blue?",
        // "What is the answer to the ultimate question of Life, The Universe, and Everything?",
        // "Why is the rum gone?",
        // "Are we there yet?",
        // "WHO IS Alex Trebek?",
        // "Whatcha doin'?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the scariest thing that happened today and how did I deal with it?",
        "What promptings from the Spirit did I recieve today?",
        "What can I do tommorow to make it better than today?"
    };

    public void BuildEntry()
    {
        Random random = new Random();
        
        Prompt = promptList[random.Next(0, promptList.Count)];
        Console.Clear();
        Console.Write($"Please answer the following prompt and then hit the Enter key:\n{Prompt}\n>>> ");
        EntryText = Console.ReadLine();
    }
}

