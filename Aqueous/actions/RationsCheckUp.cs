namespace Aqueous;

public class RationsCheckUp : Action {
    public override string GetName() {
        return "Check on rations";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Storage;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Checking up on rations....");
    }
}