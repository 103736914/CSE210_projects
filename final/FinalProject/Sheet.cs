public class Sheet : Box
{
    public Sheet()
    {
        Console.Clear();
        Console.Write("Please provide a Name for your sheet.\n>>> ");
        Name = Console.ReadLine();
        Console.WriteLine("Sheet named. Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
    
    public override string Menu()
    {
        int userInput = RunMenu($"You are currently navigated to: {Name}\n\n1. This program is not well developed yet. (This is definitely not what the menu will end up as.)\n2. This menu is here as an example of what interacting with the menu will be like (albeit with longer menu option text than the final menu will have).\n3. You can try to break it if you want; the code should only accept inputs matching the menu option numbers.\n4. The first 3 options will lead you back to this menu, 4 makes a Number element.\n5. The fifth will end the program, so enter \"5\" to exit.\n\nPlease input a menu item number:", 5);

        if (userInput == 5)
        {
            Console.Clear();
            return "";
        }
        else if (userInput == 4)
        {
            Console.Clear();
            Number temp = new Number();
            temp.Menu();
            Console.WriteLine("Welcome Back!");
            Menu();
            return "";
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"You chose option {userInput}. Hit enter to continue back to the menu.");
            Console.ReadLine();
            Menu();
            return "";
        }
    }
}

