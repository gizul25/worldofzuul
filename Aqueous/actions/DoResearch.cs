namespace Aqueous;

public class DoResearch : Action {
    public DoResearch()
    {
        Enable();
    }

    public override string GetName() {
        return "Do research";
    }

    public override Type GetRoom() {
        return typeof(PrimaryResearch);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        Console.WriteLine("Doing research....");
    }
}