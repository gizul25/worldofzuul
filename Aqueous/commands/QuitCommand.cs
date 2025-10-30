using Aqueous;

public class QuitCommand : SimpleCommand {
    public override string GetName() {
        return "quit";
    }

    public override void Run(GameState state) {
        state.ShouldExit = true;
    }
}