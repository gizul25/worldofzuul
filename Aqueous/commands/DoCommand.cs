using Aqueous;

public class DoCommand : Command {
    public override bool TryExecute(string input, GameState state) {
        if (!input.StartsWith("do ")) {
            return false;
        }

        string parameterString = input.Substring(3);
        int parameterInt;
        try {
            parameterInt = int.Parse(parameterString);
        } catch (Exception) {
            Console.WriteLine("Invalid action number");
            return false;
        }

        int index = parameterInt - 1;
        if (index < 0 || index >= state.actionManager.AvailableActions.Count) {
            Console.WriteLine("Action number out of range");
            return false;
        }

        Aqueous.Action action = state.actionManager.AvailableActions[index];
        Run(state, action);
        return true;
    }

    public void Run(GameState state, Aqueous.Action action) {
        action.Perform(state);
    }
}