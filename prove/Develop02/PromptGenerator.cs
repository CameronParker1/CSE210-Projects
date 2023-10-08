using System;
using System.Collections.Generic;
using System.ComponentModel;

public class PromptGenerator 
{
    List<string> Prompts = new List<string>

    {
        "What are all the things you're grateful for today?",
        "What are some things that give your life meaning?",
        "What are three good things about today?",
        "What big dreams do you have?",
        "What was something positive you experienced recently?",
    };

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, Prompts.Count);
        string randomString = Prompts[randomIndex];

        Console.WriteLine(randomString);

        return randomString;
    }
    


}