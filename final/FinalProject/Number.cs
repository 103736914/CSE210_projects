public class Number : Data
{
    public float Value { get; set; }

    public Number()
    {
        Console.Clear();
        Console.Write("Please provide a Name for your Number element.\n>>> ");
        Name = Console.ReadLine();
        Console.WriteLine("Element named. Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    // π07E.70.5E17.:.9Eππ017E.71415.ππEπ1,7.017E991DE...
    public override string Menu()
    {
        int userInput = RunMenu($"You are currently navigated to: {Name}\n\n1. This menu is smaller than the sheet menu (and, like it, not what the final menu will be like).\n2. Again, it's just to have something here for demonstration purposes.\n3. These options all return you to the sheet menu.\nPlease input a nemu item number:", 3);
        Console.Clear();
        Console.WriteLine($"You chose option {userInput}. Hit Enter to continue back to the sheet menu.");
        Console.ReadLine();
        return "";
    }

    public override void Display(int depth)
    {
        //
    }
}

