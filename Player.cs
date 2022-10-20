class Player 
{
    public string Guess(){
       Console.WriteLine("Guess a letter [A-Z]:  ");
       string letter = Console.ReadLine();
       if (letter != null){
        return letter;
       }
       else {
        return "";
       }
       
    }

}
    
