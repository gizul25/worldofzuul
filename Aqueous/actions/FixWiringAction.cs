namespace Aqueous;

public class FixWiringAction : Action {
    public override string GetName() {
        return "Fix wiring";
    }

    public override Type GetRoom() {
        return typeof(Electrical);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Fixing electrical....");
    }
}