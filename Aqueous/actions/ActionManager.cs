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
        new RationsCheckUp()
    ];
    public List<Action> AvailableActions { get; private set; } = new List<Action>();

    public void UpdateAvailableActions(GameState state) {
        AvailableActions.Clear();
        foreach (Action action in allActions) {
            if (action.CanPerform(state)) {
                AvailableActions.Add(action);
            }
        }
    }

    public void PrintAvailableActions() {
        for (int i = 0; i < AvailableActions.Count; i++) {
            Action action = AvailableActions[i];
            Console.WriteLine("[" + (i+1) + "] " + action.GetName());
        }
    }
}