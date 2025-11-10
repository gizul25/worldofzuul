namespace Aqueous;

public class ActionManager {
    static Action[] allActions = [
        new FixWiringAction(),
        new EatFood(),
        new Sleep(),
        new CheckingOnMeds(),
        new DoResearch(),
        new Socialize(),
        new DoExperiments(),
        new SecurityCheck(),
        new ShieldMaintenance(),
        new FeedMickey(),
        new RationsCheckUp(),
        new RatTrapStorage(),
        new RatTrapDelivery(),
        new RatTrapShields(),
        new RatTrapCoolingSystem(),
        new RatTrapCrewCabin(),
        new PetCat(),
        new TalkToJoey(),
        new TalkToJoey2(),
        new TalkToSteve(),
        new FeedTheCat(),
        new TalkToViktor(),
    ];
    public List<Action> AvailableActions { get; private set; } = new List<Action>();

    /// Returns the action given the type of the action
    public Action GetAction<T>() {
        foreach (Action action in allActions) {
            if (action is T) {
                return action;
            }
        }
        throw new Exception("Action not found.");
    }

    /// Returns active quests which are part of any quest
    public List<Action> GetCurrentQuestActions(GameState state) {
        List<Action> actions = new List<Action>();
        foreach (Action action in allActions) {
            if (!action.IsActive(state)) {
                continue;
            }
            if (action.GetQuestType() == null) {
                continue;
            }
            actions.Add(action);
        }
        return actions;
    }

    /// Updates list of available actions to perform in a room.
    /// Updated after every command.
    public void UpdateAvailableActions(GameState state) {
        AvailableActions.Clear();
        foreach (Action action in allActions) {
            if (action.CanPerform(state)) {
                AvailableActions.Add(action);
            }
        }
    }

    /// Prints all the available commands
    public void PrintAvailableActions() {
        for (int i = 0; i < AvailableActions.Count; i++) {
            Action action = AvailableActions[i];
            Console.WriteLine("[" + (i+1) + "] " + action.GetName());
        }
    }
}