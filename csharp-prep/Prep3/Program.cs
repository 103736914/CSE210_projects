using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }
}

