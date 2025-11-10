namespace Aqueous;

public class SecurityCheck : Action {
    public SecurityCheck() {
        Enable();
    }

    public override string GetName() {
        return "Security check";
    }

    public override Type GetRoom() {
        return typeof(Security);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override bool IsActive(GameState state) {
        if (!base.IsActive(state)) {
            return false;
        }
        if (!state.itemManager.HasItem<SecurityKey>()) {
            return false;
        }
        return true;
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        state.itemManager.ConsumeItem<SecurityKey>();
        Console.WriteLine("Security check up....");
    }
}