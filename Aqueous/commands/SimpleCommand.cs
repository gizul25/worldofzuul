namespace Aqueous;

public class SimpleCommand : Command {
    public override bool TryExecute(string input, GameState state) {
        if (input != GetName()) {
            return false;
        }

        Run(state);
        return true;
    }

    public virtual string GetName() {
        return "unimplemented";
    }

    public virtual void Run(GameState state) {}
}