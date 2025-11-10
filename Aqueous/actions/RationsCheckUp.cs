namespace Aqueous;

public class RationsCheckUp : Action {
    public RationsCheckUp()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Check on rations";
    }

    public override Type GetRoom() {
        return typeof(Storage);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        Console.WriteLine("Checking up on rations....");
    }
}