using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What was your grade percentage? (Please round to the nearest whole number.) ");
        string gradePercentageString = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageString);

        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your score: {letter}. ");
        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations on passing!");
        }
        else
        {
            Console.Write("You didn't pass. Better luck next time!");
        }
    }
}

