class Game 
{
    Word word = new Word();
    List<string> wordWithSpaces = new List<string>();
    List<string> wordList;
    public Game ()
    {
        wordList = word.GetWord();
        for (int i = 0; i <= wordList.Count()-1; i++)
        {
            wordWithSpaces.Add("_");
        }
    }

    public void Print()
    {
        foreach (string letter in wordWithSpaces)
        {
            Console.Write ($"{letter} ");
        }
        Console.WriteLine();
    }

    public bool Check(string guess)
    {
        if (wordList.Contains(guess))
        {
            AdjustWord(guess);
            return true;
        }
        else
        {
            return false;
        }
    }

    void AdjustWord (string guess)
    {
        int index = 0;
        foreach (string letter in wordList)
        {
            if (letter == guess)
            {
                wordWithSpaces[index] = guess;
            }
            index += 1;
        }
    }

    public bool IsGameDone ()
    {
        bool done = true;
        foreach (string letter in wordWithSpaces)
        {
            if (letter == "_")
            {
                done = false;
            }
        }
        return done;
    }

}
