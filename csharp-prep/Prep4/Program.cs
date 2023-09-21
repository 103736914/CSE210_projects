using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput = 1;
        int largestNumber = -999999;
        float inputsTotal = 0;
        List<int> userInputs = new List<int>();

        while (userInput > 0)
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                userInputs.Add(userInput);

                inputsTotal += userInput;

                if (userInput > largestNumber)
                {
                    largestNumber = userInput;
                }
            }

        }

        Console.WriteLine($"The sum is: {inputsTotal}");
        Console.WriteLine($"The average is: {inputsTotal / userInputs.Count}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}

