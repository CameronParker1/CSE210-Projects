using System;

class Program
{

    static void Main(string[] args)
    {

        Reference scripture = new Reference();
        scripture.setScripture("Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.");
            
        Reference reference = new Reference();
        reference.setReference("D&C 10:5");
        
        Scripture scripture1 = new Scripture(reference.getReference(), scripture.getScripture());
        Console.Clear();

        while (!scripture1.allWordsHidden)
        {
            Console.WriteLine(scripture1.GetVisibleText());
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture1.HideRandomWord();
            Console.Clear();
        }
    }
}





    
    
    
