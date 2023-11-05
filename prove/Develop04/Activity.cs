class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityTime;
    protected DateTime _activityEndTime;

    public void ActivityOpening()
    {
        // The opening message takes 5 seconds and the activities may take extra time to finish a cycle so the times that users input will not match up perfectly with how long the program actually runs before the selected activity finishes, and inputs <= 5 will result in the activity effectively not running.
        Console.Write($"Now starting the {_activityName}.\n\n{_activityDescription}\n\nHow long would you like the activity to run? (Please provide a number of seconds.)\n>>> ");
        _activityTime = int.Parse(Console.ReadLine());
        _activityEndTime = DateTime.Now.AddSeconds(_activityTime);

        Console.Clear();
        Console.Write("Get Ready");
        Thread.Sleep(900);
        Console.Clear();
        Console.Write("Get Ready OOO");
        Thread.Sleep(900);
        Console.Clear();
        Console.Write("Get Ready 0OO");
        Thread.Sleep(900);
        Console.Clear();
        Console.Write("Get Ready 00O");
        Thread.Sleep(900);
        Console.Clear();
        Console.Write("Get Ready 000");
        Thread.Sleep(900);
        Console.Clear();
        Console.Write("Start");
        Thread.Sleep(500);
        Console.Clear();
    }

    public void ActivityClosing()
    {
        Console.Clear();
        Console.Write($"Well done! You just completed {_activityTime} seconds of the {_activityName}.");
        Thread.Sleep(5000);
        Console.Clear();
    }
}

