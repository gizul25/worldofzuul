namespace Aqueous;

public class Sleep : Action {
    public override string GetName() {
        return "Get rest";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is SleepingQuarters;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Sleeping....");
    }
}