public class Text : Data
{
    public virtual string Value { get; set; }

    public Text()
    {
        Console.Clear();
        while (true)
        {
            Console.Write($"Please enter a (textual) value for {Name}\n>>> ");
            string userInput = Console.ReadLine();
            if (userInput.Trim() != "")
            {
                Value = userInput;
                Console.Clear();
                Console.WriteLine($"{Name} value set. Press Enter to continue.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, it seems you did not enter anything. Please try again.\n");
            }
        }
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{string.Concat(Enumerable.Repeat("> ", depth + 1)) + Name} ({GetType()}): \"{Value}\"");
    }
}

