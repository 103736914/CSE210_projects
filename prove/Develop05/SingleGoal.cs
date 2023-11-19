public class SingleGoal : Goal
{
    public SingleGoal(string goalText, int points, int completed) : base(goalText, points, completed) {}

    public override int AcheiveGoal()
    {
        if (_completed == 1)
        {
            Console.Write("Goal already completed.");
            return 0;
        }
        else
        {
            _completed = 1;
            Console.Write("Goal updated; points awarded.");
            return _points;
        }
    }

    public override void DisplayGoal()
    {
        if (_completed == 1)
        {
            Console.Write("[✓]     ");
        }
        else
        {
            Console.Write("[_]     ");
        }
        Console.Write($"{_goalText} ({_points} points)");
    }
    
    public override string SaveGoal()
    {
        return $"singlegoal|||{_goalText}|||{_points}|||{_completed}";
    }
}

