namespace Aqueous;

public class SecurityCheck : OneTimeAction {
    public override string GetName() {
        return "Security check";
    }

    public override bool CanPerform(GameState state) {
        if (!base.CanPerform(state)) {
            return false;
        }
        if (!state.itemManager.HasItem<SecurityKey>()) {
            return false;
        }
        return state.CurrentRoom is Security;
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        state.itemManager.ConsumeItem<SecurityKey>();
        Console.WriteLine("Security check up....");
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }
}