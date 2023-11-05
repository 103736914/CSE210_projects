class ListingActivity: Activity
{
    private List<string> _promptList = new List<string>
    {
    //"What is the answer to the ultimate question of life, the universe, and everything?",
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What things have you had the most fun doing recently?",
    "What fun activities do you havae planned for the future?"
    };

    public ListingActivity()
    {
        base._activityName = "listing activity";
        base._activityDescription = "The listing activity gives you a prompt of things you can make a list of to remember things that you can be thankful for. Recommended time: 45 seconds";
    }

    public void RunListingActivity()
    {
        base.ActivityOpening();

        Console.Write($"{_promptList[new Random().Next(0, 7)]}\n(Press Enter after each answer.)\n\n");

        for (int i = 10; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write($"\b\b  \b");
        }

        for (int count = 0; count == 0; count++)
        {
            while (DateTime.Now < base._activityEndTime)
            {
                Console.Write(">>> ");
                Console.ReadLine();
                count++;
            }
            Console.Write($"Time's up! You listed {count} things.");
            Thread.Sleep(5000);
            Console.Clear();
        }

        base.ActivityClosing();
    }
}

