namespace Aqueous;

public class OneTimeAction : Action {
    private bool isCompleted = false;

    public override bool CanPerform(GameState state) {
        if (isCompleted) {
            return false;
        }
        return true;
    }

    public override void Perform(GameState state) {
        isCompleted = true;
    }
}