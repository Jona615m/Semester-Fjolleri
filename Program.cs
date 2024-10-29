/* Main class for launching the game
 */

class Program {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback); 
  static bool firstRun = true;
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
  }
  
  static void Main (string[] args)
  {
    InitRegistry();
    /*
    Console.WriteLine(firstRun);
    if (firstRun == true)
    {
      context.GetCurrent().Welcome();
      firstRun = false;
    }*/
    
    context.GetCurrent().Welcome();
    
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Spillet er slut!");
  }
}
