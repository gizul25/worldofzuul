namespace Aqueous;

public class Sleep : Action {
    public override string GetName() {
        return "Get rest";
    }

    public override Type GetRoom() {
        return typeof(SleepingQuarters);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Sleeping....");
    }
}