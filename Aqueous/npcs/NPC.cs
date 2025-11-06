namespace Aqueous;

public class NPC {
    public virtual string GetName() {
        return "unimplemented";
    }

    public virtual string GetJobTitle() {
        return "unimplemented";
    }

    public virtual Type GetRoom() {
        return typeof(Room);
    }
}