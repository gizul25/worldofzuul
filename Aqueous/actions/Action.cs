namespace Aqueous;

public class Action {
    /// Controls if the action can perform check should even run in the first
    /// place. Used to enable/disable new actions after completing some of them.
    private bool isEnabled = false;
    
    /// Returns display name of the action
    public virtual string GetName() {
        return "unimplemented";
    }

    /// Returns the type of the room in which the action is located and needs
    /// to be performed
    public virtual Type GetRoom() {
        return typeof(Room);
    }
    
    /// Returns the type of the quest this action is part of. `null` if action
    /// is not included in any quest.
    public virtual Type? GetQuestType() {
        return null;
    }

    /// Checks if action can be performed when this action is enabled. Generally
    /// this function should not be modified and `IsActive()` should be changed.
    public virtual bool CanPerform(GameState state) {
        if (!IsActive(state)) {
            return false;
        }
        return state.CurrentRoom.GetType() == GetRoom();
    }

    /// Returns if the action could be performed if player would be in the room.
    /// This is the place to implement item checks or other conditional checks.
    /// Note that enabled check and room check are done by this parent class.
    /// Don't forget to call `base.IsActive()` if overriding this function.
    public virtual bool IsActive(GameState state) {
        return isEnabled;
    }

    /// Enables this action to be performed. Use this for unlocking new actions
    /// in the questline after completing another action.
    public void Enable() {
        isEnabled = true;
    }

    /// Disables this action. Use this to prevent this action to be completed
    /// multiple times. Generally should be called from `Perform()`.
    public void Disable() {
        isEnabled = false;
    }

    /// A function which is called to execute the action when it is guaranteed
    /// it meets all action requirements to run
    public virtual void Perform(GameState state) {}
}