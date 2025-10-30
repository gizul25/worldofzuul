using Aqueous;

public class ActionsCommand : SimpleCommand {
    public override string GetName() {
        return "actions";
    }

    public override void Run(GameState state) {
        state.actionManager.PrintAvailableActions();
        if (state.actionManager.AvailableActions.Count > 0) {
            Console.WriteLine("Enter \"do <num>\" to perform the action, e.g. \"do 1\"");
        } else {
            Console.WriteLine("No actions");
        }
    }
}