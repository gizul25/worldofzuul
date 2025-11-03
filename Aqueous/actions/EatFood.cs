namespace Aqueous;

public class EatFood : Action {
    public override string GetName() {
        return "Eat food";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Cafeteria;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Eating food....");
    }
}