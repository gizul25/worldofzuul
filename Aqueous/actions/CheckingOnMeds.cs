namespace Aqueous;

public class CheckingOnMeds : Action {
    public override string GetName() {
        return "Check on medical equipment";
    }

    public override Type GetRoom() {
        return typeof(MedBay);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Checking on medical equipment....");
    }
}