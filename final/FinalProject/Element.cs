public class Element
{
    public string Name { get; set;} = "<<An error has occured>>";

    public Element()
    {
        Console.Clear();
        Console.Write($"Please provide a name for your new {GetType()}.\n>>> ");
        Name = Console.ReadLine();
        Console.WriteLine($"{Name} created. Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    public int RunMenu(string menu, int options)
    {
        string userInput = "";
        Console.Clear();

        while (true)
        {
            Console.WriteLine(menu);
            Console.Write(">>> ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userInputInteger) && 0 < userInputInteger && userInputInteger <= options)
            {
                Console.Clear();
                return userInputInteger;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that does not seem to be an option. Please try again.\n");
            }
        }
    }

    public virtual string Menu()
    {
        return "error";
    }
    
    public virtual void Display(int depth)
    {
        Console.WriteLine("<<An error has occured>>");
    }
}

