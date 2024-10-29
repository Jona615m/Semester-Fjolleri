/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
  public Space (String name) : base(name)
  {
  }
  public static void TypeEffect(string message, int delay = 10)
  {
    foreach (char c in message)
    {
      //Det ovenfor bliver printed med et foreachloop hvor der er et delay på 10 mellem hvert bogstav
      Console.Write(c); 
      Thread.Sleep(delay); // Delay mellem hver karakter der bliver udskrevet
    }
    Console.WriteLine(); //Rykker til næste linje efter det er blevet printed 
  }
  
  public void Welcome () {
    
    Console.Write("Please enter your name: ");
    string playerName = Console.ReadLine();

    // bruger TypeEffect metoed til at printe velkomstbeskeden med effekten
    TypeEffect($"Welcome {playerName}! Are you ready to learn something about recycling your world?");
    
    Console.WriteLine("\nPress Enter to continue ... your journey");
    Console.ReadLine();

    // Bruges til at skrive resten af velkomst beskeden
    TypeEffect($"\nYou're now outside at the park");

    // her bliver der gjort så vi tager vores "exit" udskriver den med vores effekt vi lavede tidligere 
    string[] exits = {name};
    TypeEffect($"\n{playerName}, You can now go to the following routes:");
        
    foreach (string exit in exits)
    {
      TypeEffect(" - " + exit, 100); // Effekt og skriver vores "paths" langsommere 
    }
  }
  
  public void Goodbye () {
    TypeEffect("Goodbye! See you next time!", 100);
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
