using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        Fraction first = new Fraction();
        first.SetTop(1);
        first.SetBottom(1);
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        
        Fraction second = new Fraction(5);
        second.SetBottom(1);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        
        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
        
        Fraction fourth = new Fraction(1, 3);
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());


    }
}

