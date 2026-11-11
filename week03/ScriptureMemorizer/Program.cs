using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Reference for the scripture passage
        Reference reference = new Reference("Isaiah", 40, 31);

        // 2. Scripture passage
        string scriptureText = "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // 3. Display scripture and hide words
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to hide more words or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide 2 random words at a time
            scripture.HideRandomWords(2);
        }
    }
}