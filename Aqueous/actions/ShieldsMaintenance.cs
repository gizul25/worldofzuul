namespace Aqueous;

public class ShieldMaintenance : Action {
    public override string GetName() {
        return "Maintain shields";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Shields;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Maintaining shields....");
    }
}