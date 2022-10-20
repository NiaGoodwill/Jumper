
Parachute parachute = new Parachute();
Game game = new Game();
Player player = new Player();

int stage = 0;
while (stage <= 3){
    game.Print();
    parachute.Display();
    string letter = player.Guess();
    Console.WriteLine();
    bool correct = game.Check(letter);
    if (correct == false)
    {
        stage += 1;
        parachute.Delete();
    }
    
}
game.Print();
parachute.Display();





