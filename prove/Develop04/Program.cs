using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        string ActivityChoice = "";
        bool InputIsValid = false;

        Console.Clear();
        Console.Write("Welcome to the mindfulness program! ");

        while (!InputIsValid)
        {
            Console.Write("Please enter the number of the activity you would like to try:\n1. Breathing activity\n2. Reflection activity\n3. Listing activity\n4. None (quit)\n>>> ");
            ActivityChoice = Console.ReadLine();
            Console.Clear();
            if (ActivityChoice == "1")
            {
                InputIsValid = true;
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunBreathingActivity();
            }
            else if (ActivityChoice == "2")
            {
                InputIsValid = true;
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunReflectionActivity();
            }
            else if (ActivityChoice == "3")
            {
                InputIsValid = true;
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunListingActivity();
            }
            else if (ActivityChoice == "4")
            {
                InputIsValid = true;
                Console.Write("Have a great day!");
                Thread.Sleep(2500);
                Console.Clear();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, I do not understand your input.");
            }

            if (InputIsValid)
            {
                Console.Clear();
                Console.Write("Would you like to do another mindfulness activity?\n>>> ");
                if (new List<string>{ "y", "yes", "yup", "yeah" }.Contains(Console.ReadLine().ToLower()))
                {
                    InputIsValid = false;
                }
                Console.Clear();
            }
        }
    }
}

