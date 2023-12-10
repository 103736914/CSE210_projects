public class BonusText : Text
{
    public override string Value { get; set; }

    public BonusText()
    {}

    public override string Menu()
    {
        while (true)
        {
            int userInput = RunMenu($"You are currently navigated to: {Name}\n\n1. Display the value of {Name}\n2. Navigate up (exit {Name})\nPlease input a menu item number:", 2);

            // Display Value
            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine($"{string.Concat(Enumerable.Repeat("> ", userInput + 1)) + Name} ({GetType()}): \"{Value}\"");
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
            // Navigate up
            else if (userInput == 2)
            {
                Console.Clear();
                return RunMenu($"How many layers would you like to move up through? (1 moves up to the parent element of {Name}; maximum of 9)", 9).ToString();
            }
            // Anything Else
            else
            {return "error";}
        }
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{string.Concat(Enumerable.Repeat("> ", depth + 1)) + Name} (BonusText)");
    }
}

