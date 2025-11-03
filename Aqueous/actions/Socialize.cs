namespace Aqueous;

public class Socialize : Action {
    public override string GetName() {
        return "Socialize";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is Cafeteria;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Socializing....");
    }
}