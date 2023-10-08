using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)

    {
        int choice = 0;

        Entry userEntry = new Entry();
        Journal savedEntries = new Journal();
        
        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            choice = int.Parse(answer);


            if (choice == 1)
            {
                userEntry.WriteEntry();
            }

            else if (choice == 2)
            {
                userEntry.DisplayEntries();
            }

            else if (choice == 3)
            {
                savedEntries.PromptForFileName();
                savedEntries.LoadEntries();
            }

            else if (choice == 4)
            {
                savedEntries.PromptForFileName();
                savedEntries.SaveEntries(userEntry.JournalEntries);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Thank you!");
            }

            else
            {
               Console.WriteLine("Invalid Option");
            }

        }
        while (choice != 5);

    }
}






    
    