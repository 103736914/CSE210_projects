using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");

        Console.Clear();
        Console.Write("Welcome to the sheet creation program. Sheet saving/loading functionality has not (yet) been added to this program, so you will need to start on a new sheet.\nPress Enter to continue.");
        Console.ReadLine();

        Sheet activeSheet = new Sheet();
        activeSheet.Menu();
        
        Console.Clear();
        Console.Write("Thank you for using the sheet creation program. Have a great day!");
        Console.ReadLine();
        Console.Clear();
    }
}

