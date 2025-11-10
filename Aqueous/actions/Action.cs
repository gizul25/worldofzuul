namespace Aqueous;

public class Action {
    private bool isEnabled = false;
    
    public virtual string GetName() {
        return "unimplemented";
    }

    public virtual Type GetRoom() {
        return typeof(Room);
    }

    public virtual Type? GetQuestType() {
        return null;
    }

    public virtual bool CanPerform(GameState state) {
        if (!IsActive(state)) {
            return false;
        }
        return state.CurrentRoom.GetType() == GetRoom();
    }

    // If the action could be performed if player would be in the room
    public virtual bool IsActive(GameState state) {
        return isEnabled;
    }

    public void Enable() {
        isEnabled = true;
    }

    public void Disable() {
        isEnabled = false;
    }

    public virtual void Perform(GameState state) {}
}