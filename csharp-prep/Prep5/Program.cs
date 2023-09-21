using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int inputInteger)
    {
        return inputInteger * inputInteger;
    }

    static void DisplayResult(string nameOfUser, int squaredNumber)
    {
        Console.Write($"{nameOfUser}, the square of your favorite number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        // DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

        string nameOfUser = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(nameOfUser, squaredNumber);
        
    }
}

