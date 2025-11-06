namespace Aqueous;

public class DoResearch : Action {
    public override string GetName() {
        return "Do research";
    }

    public override Type GetRoom() {
        return typeof(PrimaryResearch);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Doing research....");
    }
}