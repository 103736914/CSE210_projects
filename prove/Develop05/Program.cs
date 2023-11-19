using System;

class Program
{
    //UserInput1 is used a few places in the code when it is handy to have a value saved and it does not make sense to dedicate a seperate variable to the task, such as when the user's input just needs to be checked against some values but it's value will not need to be saved anywhere. UserInput2 is for when it is handy to have an additional value saved at the same time.
    public static string UserInput1 = "";
    public static string UserInput2 = "";

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");


        string username = "";
        Profile userProfile = new Profile("There has been an error. This profile does not exist. Please restart the program.");

        //Program start; loading or creation of user profile
        Console.Clear();
        Console.Write("Welcome to the goal tracker program! ");
        while (username == "")
        {
            Console.Write("Do you have a pre-existing profile that you would like to load?\n>>> ");
            UserInput1 = Console.ReadLine().ToLower().Trim();
            if (new List<string>{ "1", "y", "ye", "yes", "yup", "yeah", "i do"}.Contains(UserInput1))
            {
                Console.Clear();
                Console.Write("What is your username?\n>>> ");
                username = Console.ReadLine();
                while (!File.Exists($"profile{username}.txt"))
                {
                    username = Console.ReadLine();
                    if (!File.Exists($"profile{username}.txt"))
                    {
                        Console.Write("I'm sorry, that user profile does not appear to exist. Please try a different username.\n>>> ");
                    }
                }
                userProfile.Load($"profile{username}.txt");
                Console.Write("Profile loaded.");
                Thread.Sleep(3000);
            }
            else if (new List<string>{ "0", "n", "no", "nope", "nah", "i don't", "i do not"}.Contains(UserInput1))
            {
                Console.Clear();
                Console.Write("Creating new profile.\nWhat would you like your username to be?\n>>> ");
                username = Console.ReadLine().Trim();
                while (File.Exists($"profile{username}.txt"))
                {
                    Console.Clear();
                    Console.Write("I'm sorry, that username is taken.\nWhat would you like your username to be?\n>>> ");
                    username = Console.ReadLine();
                }
                userProfile = new Profile(username);
                Console.Write("Profile created.");
                Thread.Sleep(3000);
            }
            else
            {
                Console.Clear();
                Console.Write("I'm sorry, I do not understand your input. ");
            }
        }
        Console.Clear();

        //Main menu
        string UserInput2 = "valid";
        while (true)
        {
            Console.Clear();
            userProfile.ShowProfile();
            Console.WriteLine("\n");
            if (UserInput2 == "invalid")
            {
                Console.Write("I'm sorry, I did not understand your input. ");
            }
            Console.Write("What would you like to do?\n(1) Add a goal\n(2) View goals\n(3) Mark that you accomplished a goal\n(4) Save your goals (do this before exiting)\n(5) Exit the program\n>>> ");
            UserInput1 = Console.ReadLine().ToLower().Trim();
            UserInput2 = "valid";

        
            if (new List<string>{ "1", "(1)", "1.", "one", "one.", "add", "add a goal"}.Contains(Program.UserInput1))
            {
                UserInput2 = "valid";
                Console.Clear();
                userProfile.AddGoal();
                Console.WriteLine();
                Console.Write("Goal added. Press the Enter key to return to the menu.");
                Console.ReadLine();
            }
            else if (new List<string>{ "2", "(2)", "2.", "two", "two.", "view", "view goals", "view my goals"}.Contains(Program.UserInput1))
            {
                UserInput2 = "valid";
                Console.Clear();
                userProfile.ShowGoals();
                Console.WriteLine();
                Console.Write("Press the Enter key to return to the menu.");
                Console.ReadLine();
            }
            else if (new List<string>{ "3", "(3)", "3.", "three", "three.", "mark"}.Contains(Program.UserInput1))
            {
                UserInput2 = "valid";
                Console.Clear();
                userProfile.UpdateGoal();

            }
            else if (new List<string>{ "4", "(4)", "4.", "four", "four.", "save", "save goals", "save my goals"}.Contains(Program.UserInput1))
            {
                UserInput2 = "valid";
                Console.Clear();
                userProfile.Save();
                Console.Clear();
                Console.Write("Goals saved.");
                Thread.Sleep(2000);
            }
            else if (new List<string>{ "5", "(5)", "5.", "five", "five.", "exit", "exit program", "exit the program"}.Contains(Program.UserInput1))
            {
                UserInput2 = "valid";
                Console.Clear();
                Console.Write("Thanks for using the goal tracker program.\nHave a great day!");
                Thread.Sleep(5000);
                Console.Clear();
                return;
            }
            else
            {
                Console.Clear();
                UserInput2 = "invalid";
            }
        }
    }
}

