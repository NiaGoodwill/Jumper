class Game 
{
    Word word = new Word();
    List<int> board = new List<int>();
    List<string> wordList;
    public Game ()
    {
        for (int i = 1; i <= 9; i++)
        {
            board.Add (i);
        } 
    }
}