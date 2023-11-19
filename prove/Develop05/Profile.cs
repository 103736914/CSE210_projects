using System.IO;

public class Profile
{
    private string _userName;
    private int _score = 0;
    private List<Goal> _goals = new List<Goal>();

    public Profile(string username)
    {
        _userName = username;
    }
    public void ShowProfile()
    {
        Console.Write($"     Username: {_userName}\n  Total score: {_score}\nGoals entered: {_goals.Count()}");
    }
    public void ShowGoals()
    {
        for (int i = 1; i <= _goals.Count(); i++)
        {
            Console.Write($"{i}     ");
            _goals[i-1].DisplayGoal();
            Console.WriteLine();
        }
    }
    public void AddGoal()
    {
        Program.UserInput1 = "repeat";
        while(Program.UserInput1 == "repeat")
        {
            Console.Write("What kind of goal would you like to add?\n(1) One-time Goal—goal to be completed once\n(2) Repeating Goal—goal to be completed multiple times\n(3) Eternal Goal—goal to be completed multiple times without end\n>>> ");
            Program.UserInput1 = Console.ReadLine().ToLower().Trim();
                if (new List<string>{ "1", "(1)", "1.", "one", "one.", "one-time", "one-time goal"}.Contains(Program.UserInput1))
                {
                    Console.Write("\nWhat is your goal? (What do you plan to accomplish?)\n>>> ");
                    Program.UserInput1 = Console.ReadLine();

                    Console.Write("\nHow many points is this goal worth?\n>>> ");
                    Program.UserInput2 = Console.ReadLine();
                    int points;
                    while (!int.TryParse(Program.UserInput2, out points))
                    {
                        Console.Write("\nPlease enter a number. How many points is this goal worth?\n>>> ");
                        Program.UserInput2 = Console.ReadLine();
                    }
                    points = int.Parse(Program.UserInput2);
                    
                    _goals.Add(new SingleGoal(Program.UserInput1, points, 0));
                }
                else if (new List<string>{ "2", "(2)", "2.", "two", "two.", "repeating", "repeating goal"}.Contains(Program.UserInput1))
                {
                    Console.Write("\nWhat is your goal? (What do you plan to accomplish?)\n>>> ");
                    Program.UserInput1 = Console.ReadLine();

                    Console.Write("\nHow many points is this goal worth?\n>>> ");
                    Program.UserInput2 = Console.ReadLine();
                    int points;
                    while (!int.TryParse(Program.UserInput2, out points))
                    {
                        Console.Write("\nPlease enter a number. How many points is this goal worth?\n>>> ");
                        Program.UserInput2 = Console.ReadLine();
                    }
                    points = int.Parse(Program.UserInput2);
                    
                    Console.Write("\nHow many times do you want to accomplish this goal?\n>>> ");
                    Program.UserInput2 = Console.ReadLine();
                    int repetition;
                    while (!int.TryParse(Program.UserInput2, out points))
                    {
                        Console.Write("\nPlease enter a number. How many times do you want to accomplish this goal?\n>>> ");
                        Program.UserInput2 = Console.ReadLine();
                    }
                    repetition = int.Parse(Program.UserInput2);
                    
                    _goals.Add(new MultiGoal(Program.UserInput1, points, 0, repetition));
                }
                else if (new List<string>{ "3", "(3)", "3.", "three", "three.", "eternal goal", "eternal goal"}.Contains(Program.UserInput1))
                {
                    Console.Write("\nWhat is your goal? (What do you plan to accomplish?)\n>>> ");
                    Program.UserInput1 = Console.ReadLine();

                    Console.Write("\nHow many points is this goal worth?\n>>> ");
                    Program.UserInput2 = Console.ReadLine();
                    int points;
                    while (!int.TryParse(Program.UserInput2, out points))
                    {
                        Console.Write("\nPlease enter a number. How many points is this goal worth?\n>>> ");
                        Program.UserInput2 = Console.ReadLine();
                    }
                    points = int.Parse(Program.UserInput2);
                    
                    _goals.Add(new SingleGoal(Program.UserInput1, points, 0));
                }
                else
                {
                    Console.Clear();
                    Program.UserInput1 = "repeat";
                    Console.Write("I'm sorry, I did not understand your input. ");
                }
        }
    }
    public void UpdateGoal()
    {
        Console.Write("\nWhich goal did you accomplish? (Enter \"c\" to cancel)\n>>> ");
        Program.UserInput1 = Console.ReadLine();
        int goalNumber;
        while (!int.TryParse(Program.UserInput1, out goalNumber) || goalNumber > _goals.Count())
        {
            if (Program.UserInput1.ToLower().Trim() == "c")
            {
                return;
            }
            Console.Write("\nPlease enter the number of a goal from the goal list or \"c\" to cancel.\n>>> ");
            Program.UserInput1 = Console.ReadLine();
        }
        // AchieveGoal marks a gail as achieved (if relelvant) and returns the number of points it was worth
        _score += _goals[goalNumber-1].AcheiveGoal();
        Thread.Sleep(3000);
    }
    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter($"profile{_userName}.txt"))
        {
            outputFile.WriteLine($"{_userName}|||{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void Load(string filename)
    {
        string[] goals = System.IO.File.ReadAllLines(filename);
        foreach (string goalLine in goals)
        {
            string[] element = goalLine.Split("|||");
            
            if (element[0] == "singlegoal")
            {
                _goals.Add(new SingleGoal(element[1], int.Parse(element[2]), int.Parse(element[3])));
            }
            else if (element[0] == "multigoal")
            {
                _goals.Add(new MultiGoal(element[1], int.Parse(element[2]), int.Parse(element[3]), int.Parse(element[4])));
            }
            else if (element[0] == "infinigoal")
            {
                _goals.Add(new InfiniGoal(element[1], int.Parse(element[2]), int.Parse(element[3])));
            }
            else
            {
                _userName = element[0];
                _score = int.Parse(element[1]);
            }
        }
    }
    }

