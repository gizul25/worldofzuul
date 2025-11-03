namespace Aqueous;

public class DoResearch : Action {
    public override string GetName() {
        return "Do research";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is PrimaryResearch;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Doing research....");
    }
}