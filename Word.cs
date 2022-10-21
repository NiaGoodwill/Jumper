class Word
{
    Random random = new Random();
    List<string> wordList = new List<string>();
    List<string> charList = new List<string>();
    string[] words = { "thunder", "quarter", "payment", "idea", "milk", "weather", 
    "afterthought", "canvas", "island", "number", "rail", "snow", "dress", "smoke", "letter", 
    "deer", "rub", "town", "tub", "relation", "juice", "vest", "reason", "houses", "regret",
     "knowledge", "eggnog", "eye", "fire", "spark", "cable", "robin", "tax", "pie", "quicksand", "airplane", 
     "smile", "haircut", "kitty", "sand", "ants", "sky", "pancake", "territory", "plough", "box", "army", "edge", 
     "crayon", "cook", "berry", "sail", "flowers", "playground", "brass", "mother", "locket", "view", "soda", "cow"};
    public Word()
    {
        wordList.AddRange (words);
        string theWord = NewWord();
        CreateListOfChar(theWord);
    }

    string NewWord()
    {
        int randIndex = random.Next(wordList.Count());
        string newWord = wordList[randIndex];
        return newWord;
    }

    void CreateListOfChar(string word)
    {
        foreach (char letter in word)
        {
            charList.Add (letter.ToString());
        }
    }

    public List<string> GetWord()
    {
        return charList;
    }
}