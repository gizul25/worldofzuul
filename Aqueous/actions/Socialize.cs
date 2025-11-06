namespace Aqueous;

public class Socialize : Action {
    public override string GetName() {
        return "Socialize";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Socializing....");
    }
}