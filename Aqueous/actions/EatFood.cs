namespace Aqueous;

public class EatFood : Action {
    public override string GetName() {
        return "Eat food";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Eating food....");
    }
}