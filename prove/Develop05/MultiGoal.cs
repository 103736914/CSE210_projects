public class MultiGoal : Goal
{
    protected int _completionGoal;
    public MultiGoal(string goalText, int points, int completed, int completionGoal) : base(goalText, points, completed)
    {
        _completionGoal = completionGoal;
    }

    public override int AcheiveGoal()
    {
        if (_completed == _completionGoal)
        {
            Console.Write("Goal already completed.");
            return 0;
        }
        else
        {
            _completed++;
            if (_completed == _completionGoal)
            {
                Console.Write("Goal updated; points awarded. Bonus points awarded for final completion.");
                return _points * (1 + _completed / 2);
            }
            else
            {
                Console.Write("Goal updated; points awarded.");
                return _points;
            }
        }
    }

    public override void DisplayGoal()
    {
        if (_completed == _completionGoal)
        {
            Console.Write("[✓]     ");
        }
        else
        {
            Console.Write($"[{_completed}/{_completionGoal}]".PadRight(8));

        }
        Console.Write($"{_goalText} ({_points} points)");
    }
    public override string SaveGoal()
    {
        return $"multigoal|||{_goalText}|||{_points}|||{_completed}|||{_completionGoal}";
    }
}

