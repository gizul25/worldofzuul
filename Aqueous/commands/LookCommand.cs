namespace Aqueous;

public class LookCommand : SimpleCommand {
    public override string GetName() {
        return "look";
    }

    public override void Run(GameState state) {
        Console.WriteLine(state.CurrentRoom.GetDescription());
    }
}