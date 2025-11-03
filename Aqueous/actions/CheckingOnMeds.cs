namespace Aqueous;

public class CheckingOnMeds : Action {
    public override string GetName() {
        return "Check on medical equipment";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is MedBay;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Checking on medical equipment....");
    }
}