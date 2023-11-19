public abstract class Goal
{
    protected string _goalText;
    protected int _points;
    protected int _completed;

    public Goal(string goalText, int points, int completed)
    {
        _goalText = goalText;
        _points = points;
        _completed = completed;
    }
    public abstract int AcheiveGoal();
    public abstract void DisplayGoal();
    public abstract string SaveGoal();
}

