public class Box : Element
{
    public List<Element> Elements { get; set; }
    
    public Box()
    {
        Elements = new List<Element>();
    }

    public override string Menu()
    {
        while (true)
        {
            int userInput = RunMenu($"You are currently navigated to: {Name}\n\n1. List the contents of {Name}\n2. Add an element to {Name}\n3. Remove an element from {Name}\n4. Navigate down (enter an element of {Name})\n5. Navigate up (exit {Name})\nPlease input a menu item number:", 5);

            // List Contents
            if (userInput == 1)
            {
                Console.Clear();
                userInput = RunMenu($"How many layers would you like to view? (\"1\" to just view the names of elements in {Name}, \"2\" to also view their contents, etcetera; maximum of 9)", 9);
                Console.Clear();
                Display(userInput);
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
            // Add Element
            else if (userInput == 2)
            {
                Console.Clear();
                userInput = RunMenu("What kind of element would you like to add?\n\n1. Box (holds other elements)\n2. BonusBox (holds other elements, but keeps them hidden unless it is navigated into)\n3. Number (a number)\n4. Text (a block of text)\n5. BonusText (a block of text that keeps hidden unless it is navigated into)\n6. Cancel element addition; returns to the menu", 6);
                if (userInput == 1)
                {
                    Elements.Add(new Box());
                }
                else if (userInput == 2)
                {
                    Elements.Add(new BonusBox());
                }
                else if (userInput == 3)
                {
                    Elements.Add(new Number());
                }
                else if (userInput == 4)
                {
                    Elements.Add(new Text());
                }
                else if (userInput == 5)
                {
                    Elements.Add(new BonusText());
                }
                else if (userInput == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Nothing was added.\nPress Enter to return to the menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("An error has occurred.\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
                Console.Clear();
            }
            // Remove Element
            else if (userInput == 3)
            {
                Console.Clear();
                if (Elements.Count == 0)
                {
                    Console.WriteLine($"{Name} does not contain any elements.\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
                else
                {
                    userInput = RunMenu($"{Name} contains {Elements.Count} items. Enter the number of the item you would like to remove, or enter {Elements.Count +1} to cancel.", Elements.Count + 1);
                    if (userInput == Elements.Count + 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Nothing was removed.\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        string elementName = Elements[userInput -1].Name;
                        Elements.RemoveAt(userInput - 1);
                        Console.WriteLine($"Element {userInput} ({elementName}) removed.\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.Clear();
            }
            // Navigate Down
            else if (userInput == 4)
            {
                Console.Clear();
                if (Elements.Count == 0)
                {
                    Console.WriteLine($"{Name} does not contain any elements.\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
                else
                {
                    userInput = RunMenu($"{Name} contains {Elements.Count} items. Enter the number of the item you would like to navigate into. (1 for the first item, etcetera)", Elements.Count);
                    Console.Clear();
                    string menuReturn = Elements[userInput - 1].Menu();
                    if (menuReturn == "1")
                    {
                        Console.Clear();
                    }
                    else if (new[] { "2", "3", "4", "5", "6", "7", "8", "9" }.Contains(menuReturn))
                    {
                        Console.Clear();
                        return (int.Parse(menuReturn) - 1).ToString();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("An error has occured.\n");
                    }
                }
                Console.Clear();
            }
            // Navigate Up
            else if (userInput == 5)
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
        if (depth == 0)
        {
            if (Elements.Count == 0)
            {
            Console.WriteLine($"{Name} (Box; empty)");
            }
            else if (Elements.Count == 1)
            {
            Console.WriteLine($"{Name} (Box; contains 1 element)");
            }
            else
            {
            Console.WriteLine($"{Name} (Box; contains {Elements.Count} elements)");
            }
        }
        else if (depth >= 1)
        {
            Console.WriteLine($"{string.Concat(Enumerable.Repeat("> ", depth + 1)) + Name} (Box)");
            foreach (Element element in Elements)
            {
                element.Display(depth - 1);
            }
        }
    }
}

