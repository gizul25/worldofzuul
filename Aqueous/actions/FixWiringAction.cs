namespace Aqueous;

public class FixWiringAction : Action {
    public override string GetName() {
        return "Fix wiring";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Cafeteria;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Fixing electricall....");
    }
}