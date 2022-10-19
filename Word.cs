class Word
{
    List<string> theList = new List<string>();
    public Word()
    {
        string theWord = NewWord();
        CreateListOfChar(theWord);
    }

    string NewWord()
    {
        return "hi";
    }

    void CreateListOfChar(string word)
    {
        foreach (char letter in word)
        {
            theList.Add (letter.ToString());
        }
    }

    public List<string> GetWord()
    {
        return theList;
    }
}