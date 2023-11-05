class ReflectionActivity: Activity
{
    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you stood up for yourself.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you did something you were scared to do."
    };
    private List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        base._activityName = "reflection activity";
        base._activityDescription = "The reflection activity helps you reflect on points in your past that can inspire the present in ways that can change the course of the future. Recommended duration: 40 seconds";
    }

    public void RunReflectionActivity()
    {
        base.ActivityOpening();

        Console.Write($"{_promptList[new Random().Next(0, 6)]}\n\n ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\b▄");
            Thread.Sleep(125);
            Console.Write("\b▌");
            Thread.Sleep(125);
            Console.Write("\b▀");
            Thread.Sleep(125);
            Console.Write("\b▐");
            Thread.Sleep(125);        
        }
        
        while (DateTime.Now < base._activityEndTime)
        {
            Console.WriteLine($"\b{_questionList[new Random().Next(0, 9)]}");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("\b▄");
                Thread.Sleep(125);
                Console.Write("\b▌");
                Thread.Sleep(125);
                Console.Write("\b▀");
                Thread.Sleep(125);
                Console.Write("\b▐");
                Thread.Sleep(125);        
            }
        }

        base.ActivityClosing();
    }
}

