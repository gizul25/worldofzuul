namespace Aqueous;

public class FixWiringAction : Action {
    public override string GetName() {
        return "Fix wiring";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Electrical;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Fixing electrical....");
    }
}