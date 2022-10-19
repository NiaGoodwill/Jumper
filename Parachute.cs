class Parachute
{
    List<string> jumper = new List<string>();
    public Parachute ()
    {
        jumper.Add (@"  ___  ");
        jumper.Add (@" /___\ ");
        jumper.Add (@" \   / ");
        jumper.Add (@"  \ /  ");
        jumper.Add (@"   O   ");
        jumper.Add (@"  /|\  ");
        jumper.Add (@"  / \  ");
        jumper.Add (@"       ");
        jumper.Add (@"^^^^^^^");
    }

    public void Delete()
    {
        if (jumper[0] == @"  \ /  ")
        {
            jumper.RemoveAt(0);
            jumper[0] = "   x   ";
        }
        else
        {
            jumper.RemoveAt(0);
        }
    }

    public void Display ()
    {
        foreach (string line in jumper)
        {
            Console.WriteLine (line);
        }
    }
}