namespace Aqueous;

public class SecurityCheck : Action {
    public override string GetName() {
        return "Security check";
    }

    public override bool CanPerform(GameState state) {
        if (!state.itemManager.HasItem<SecurityKey>()) {
            return false;
        }
        return state.CurrentRoom is Security;
    }

    public override void Perform(GameState state) {
        state.itemManager.ConsumeItem<SecurityKey>();
        Console.WriteLine("Security check up....");
    }
}