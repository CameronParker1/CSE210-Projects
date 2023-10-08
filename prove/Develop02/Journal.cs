using System;
using System.Collections.Generic;
using System.IO;
public class Journal 
{
    public string fileName;
    public void PromptForFileName()
    {
        Console.Write("What is the filename?");
        fileName = Console.ReadLine();
    }

    public void SaveEntries(List<string> entries)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                foreach (string entry in entries)
                {
                    writer.WriteLine(entry);
                }
            }
            
            Console.WriteLine("Journal entries saved to " + fileName);
    }

    public void LoadEntries()
    {
         string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
    }
}