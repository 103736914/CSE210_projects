public class Data : Element
{
    public Data()
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
                Display(0);
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
}

