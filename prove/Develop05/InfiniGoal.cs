public class InfiniGoal : Goal
{
    public InfiniGoal(string goalText, int points, int completed) : base(goalText, points, completed) {}

    public override int AcheiveGoal()
    {
        _completed++;
        Console.Write("Goal updated; points awarded.");
        return _points;
    }

    public override void DisplayGoal()
    {
        Console.Write($"[{_completed}]".PadRight(8));
        Console.Write($"{_goalText} ({_points} points)");
    }
    public override string SaveGoal()
    {
        return $"infinigoal|||{_goalText}|||{_points}|||{_completed}";
    }
}

