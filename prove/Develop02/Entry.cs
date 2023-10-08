using System;
using System.Collections.Generic;

public class Entry
{
    public List<string> JournalEntries = new List<string>();
   
    public void WriteEntry()
    {

        PromptGenerator randomprompt = new PromptGenerator();
        string entryPrompt = randomprompt.GenerateRandomPrompt();

       
        Console.Write("> ");
        string entryText = Console.ReadLine(); 

        string entryDate = DateTime.Now.ToShortDateString();

        string journalEntry = $"[Date: {entryDate}] - Prompt: {entryPrompt} - Response: {entryText}";

        JournalEntries.Add(journalEntry);
        
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Latest Entries:");
        foreach (string entry in JournalEntries)
        {
            Console.WriteLine(entry);
        }
    }
}