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
        Complete();
        Console.WriteLine("You grab a few files and sit down at the desk with a heavy sigh.");
        Console.WriteLine("After a while the papers are covered in notes and highlighter. That's enough for today.");
    }
}