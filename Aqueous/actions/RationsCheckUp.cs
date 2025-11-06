namespace Aqueous;

public class RationsCheckUp : Action {
    public override string GetName() {
        return "Check on rations";
    }

    public override Type GetRoom() {
        return typeof(Storage);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Checking up on rations....");
    }
}