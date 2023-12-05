using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");

        Console.Clear();
        Console.Write("Welcome to the sheet creator program. We will be starting you on a fresh sheet today as sheet loading functionality has not yet been added to this program.\nPress Enter to continue.");
        Console.ReadLine();

        Sheet activeSheet = new Sheet();
        activeSheet.Menu();
        
        Console.Clear();
        Console.Write("Thank you for using the sheet creator program. Have a great day!");
        Console.ReadLine();
        Console.Clear();
        Console.Write("The egg emoji doesn't render correctly in the console, so I'll just have to leave this text here as an easter egg instead.");
        Console.Clear();
    }
}

