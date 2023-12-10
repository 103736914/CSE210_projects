public class Number : Data
{
    public float Value { get; set; }

    public Number()
    {
        Console.Clear();
        while (true)
        {
            Console.Write($"Please enter a (numeric) value for {Name}\n>>> ");
            string userInput = Console.ReadLine();
            if (float.TryParse(userInput, out float userInputFloat))
            {
                Value = userInputFloat;
                Console.Clear();
                Console.WriteLine($"{Name} value set. Press Enter to continue.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that does not seem to be a valid value. Please try again.\n");
            }
        }
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{string.Concat(Enumerable.Repeat("> ", depth + 1)) + Name} ({GetType()}): {Value}");
    }
}

