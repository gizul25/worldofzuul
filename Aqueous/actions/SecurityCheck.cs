namespace Aqueous;

public class SecurityCheck : Action {
    public override string GetName() {
        return "Security check";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Security;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Security check up....");
    }
}