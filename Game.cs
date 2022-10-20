class Game 
{
    Word word = new Word();
    List<int> wordWithSpaces = new List<int>();
    List<string> wordList;
    public Game ()
    {
        for (int i = 1; i <= 9; i++)
        {
            wordWithSpaces.Add (i);
        } 
    }

    public void Print()
    {
        Console.WriteLine ("Testing");
    }

    public bool Check()
    {
        return false;
    }

    void AdjustWord ()
    {

    }
}