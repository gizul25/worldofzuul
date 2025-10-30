namespace Aqueous;

public class Action {
    public virtual string GetName() {
        return "unimplemented";
    }

    public virtual bool CanPerform(GameState state) {
        return false;
    }

    public virtual void Perform(GameState state) {}
}