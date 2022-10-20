class Player 
{
    public string Guess(){
       Console.Write("Guess a letter [A-Z]:  ");
       string letter = Console.ReadLine();
       if (letter != null){
        return letter;
       }
       else {
        return "";
       }
       
    }

}
    
