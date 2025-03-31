using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }

        // Show final state
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}