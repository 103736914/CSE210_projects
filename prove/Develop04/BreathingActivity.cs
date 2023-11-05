class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        base._activityName = "breathing activity";
        base._activityDescription = "The breathing activity guides your breathing, helping you to slow down, relax, and clear your mind. Recommended duration: 50 seconds";
    }

    public void RunBreathingActivity()
    {
        base.ActivityOpening();

        while (DateTime.Now < base._activityEndTime)
        {
            Console.Clear();
            Console.Write("\n   Breathe in  ");
            Thread.Sleep(1000);
            Console.Write("\b░");
            Thread.Sleep(1000);
            Console.Write("\b▒");
            Thread.Sleep(1000);
            Console.Write("\b▓");
            Thread.Sleep(1000);
            Console.Write("\b█");
            Thread.Sleep(2000);

            Console.Clear();
            Console.Write("\n   Breathe out  ");
            Console.Write("\b▓");
            Thread.Sleep(2000);
            Console.Write("\b▒");
            Thread.Sleep(2000);
            Console.Write("\b░");
            Thread.Sleep(2000);
            Console.Write("\b ");
            Thread.Sleep(3000);
        }

        base.ActivityClosing();
    }
}

