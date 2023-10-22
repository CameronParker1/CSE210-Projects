using System;

public class Scripture
{
    private List<Word> _words;
    public bool allWordsHidden;

    public Scripture(string reference, string text)
    {
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        
        allWordsHidden = false;
        Reference = reference;
    }


    public string Reference { get; private set; }

    public void HideRandomWord()
    {
        Random random = new Random();
        Word randomWord;

        do
        {
            randomWord = _words[random.Next(_words.Count)];
        } 
        while (randomWord.IsHidden);

        randomWord.Hide();

        if (_words.All(word => word.IsHidden))
            allWordsHidden = true;
    
    }
    public string GetVisibleText()
    {
        return $"{Reference} {string.Join(" ", _words.Select(word => word.IsHidden ? "_____" : word.Text))}";
    }
}



    
