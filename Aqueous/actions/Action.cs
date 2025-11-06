namespace Aqueous;

public class Action {
    public virtual string GetName() {
        return "unimplemented";
    }

    public virtual bool CanPerform(GameState state) {
        if (!IsActive(state)) {
            return false;
        }
        return state.CurrentRoom.GetType() == GetRoom();
    }

    // If the action could be performed if would be in the room
    public virtual bool IsActive(GameState state) {
        return true;
    }

    public virtual void Perform(GameState state) {}

    public virtual Type GetRoom() {
        return typeof(Room);
    }

    public virtual Type? GetQuestType() {
        return null;
    }
}