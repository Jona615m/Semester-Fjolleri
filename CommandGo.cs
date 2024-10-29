/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Just follow a path :)";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("You are going the wrong path!");
      return;
    }
    context.Transition(parameters[0]);
  }
}
