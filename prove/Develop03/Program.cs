using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        //Starting console clear
        Console.Clear();
        
        //Scriptures and References data
        string firstScripture = "And Aaron was a descendant of Heth, who was the son of Hearthom.";
        string firstReferenceBook = "Ether";
        string firstReferenceChapter = "1";
        string firstReferenceVerseRange = "16";
        string secondScripture = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        string secondReferenceBook = "1 Nephi";
        string secondReferenceChapter = "1";
        string secondReferenceVerseRange = "1";
        string thirdScripture = "Or in other words, yield yourselves up unto us, and unite with us and become acquainted with our secret works, and become our brethren that ye may be like unto us—not our slaves, but our brethren and partners of all our substance.     And behold, I swear unto you, if ye will do this, with an oath, ye shall not be destroyed; but if ye will not do this, I swear unto you with an oath, that on the morrow month I will command that my armies shall come down against you, and they shall not stay their hand and shall spare not, but shall slay you, and shall let fall the sword upon you even until ye shall become extinct.";
        string thirdReferenceBook = "3 Nephi";
        string thirdReferenceChapter = "3";
        string thirdReferenceVerseRange = "7—8";

        //Pick scripture
        string scriptureChosen = "";
        while (scriptureChosen != "1" && scriptureChosen != "2" && scriptureChosen != "3")
        {
            Console.Write("Welcome to the scripture memorization program!\nWould you like to work on scripture 1, 2, or 3?\n>>>");
            scriptureChosen = Console.ReadLine();

            Console.Clear();

            if (scriptureChosen != "1" && scriptureChosen != "2" && scriptureChosen != "3")
            {
                Console.WriteLine("I'm sorry, I did not understand your input. (Just a single digit, please.)");
            }
        }

        //Set scripture; defaults for the scripture and the reference are set, but will never be printed to the console if the code works as intended
        Reference activeReference = new Reference("There has been an error. Please restart the program and try again.", "", "");
        Scripture activeScripture = new Scripture("There has been an error. Please restart the program and try again.");
        if (scriptureChosen == "1")
        {
            activeReference = new Reference(firstReferenceBook, firstReferenceChapter, firstReferenceVerseRange);
            activeScripture = new Scripture(firstScripture);
        }
        if (scriptureChosen == "2")
        {
            activeReference = new Reference(secondReferenceBook, secondReferenceChapter, secondReferenceVerseRange);
            activeScripture = new Scripture(secondScripture);
        }
        if (scriptureChosen == "3")
        {
            activeReference = new Reference(thirdReferenceBook, thirdReferenceChapter, thirdReferenceVerseRange);
            activeScripture = new Scripture(thirdScripture);
        }
        
        //Main loop
        Console.Clear();
        bool keepGoing = true;
        while (keepGoing)
        {
            //set reference and set/update scripture
            string referenceToPrint = activeReference.GetReference();
            string scriptureToPrint = activeScripture.GetScripture();

            //Output scripture, wait for the user
            Console.Write($"{referenceToPrint}\n{scriptureToPrint}\n\n");
            if (activeScripture.CheckIfHidden())
            {
                Console.Write("Press Enter to Continue.");
            }
            else
            {
                Console.Write("Type \"quit\" and press the Enter key to exit the program or press the Enter key to continue.\n>>>");
            }
            string quitOrNot = Console.ReadLine();

            //If the user wants to quit, the main loop condition will be set to false
            if (quitOrNot == "quit" || quitOrNot == "Quit" || quitOrNot == "q" || quitOrNot == "Q")
            {
                keepGoing = false;
            }
            else if (activeScripture.CheckIfHidden())
            {
                keepGoing = false;              
            }
            else
            {
                activeScripture.HideWords();
            }
            Console.Clear();
        }
    }
}

