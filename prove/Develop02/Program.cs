using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        string areWeDoneYet = "no";
        Journal journal = new Journal();
        Console.Clear();

        while(areWeDoneYet == "no")
        {
            Console.Write("Please pick one (enter the number):\n1. Load journal from file\n2. Add entry to current journal\n3. Save current journal to file\n4. Display current journal\n0. Exit the program\n>>> ");
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                areWeDoneYet = "yes, yes we are";
            }
            else if (userInput == "1")
            {
                journal.LoadFromFile();
                Console.Clear();
                Console.WriteLine($"{journal.Filename} loaded. It is the current journal.");
            }
            else if (userInput == "2")
            {
                journal.AddEntry();
                Console.Clear();
                Console.WriteLine("Entry added to current journal.");
            }
            else if (userInput == "3")
            {
                journal.SaveToFile();
                Console.Clear();
                Console.WriteLine($"Journal saved to {journal.Filename}");
            }
            else if (userInput == "4")
            {
                journal.DisplayJournal();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, I didn't understand your input.");
            }

        }

        Console.Clear();
        Console.Write("Thank you for using the journal program. Have a great day!");
        Thread.Sleep(3500);
        Console.Clear();
    }
}

