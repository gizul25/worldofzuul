namespace Aqueous;

public class RatTrapStorage : Action {
    private int trapsPlaced = 0;

    public override string GetName() {
        return "Setup rat trap";
    }

    public override Type GetRoom() {
        return typeof(Storage);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public void PlaceTrap() {
        int MAX_TRAPS = 5;

        trapsPlaced++;
        if (trapsPlaced == MAX_TRAPS) {
            Console.WriteLine("Placed all the traps!");
            return;
        }

        int remainingTraps = MAX_TRAPS - trapsPlaced;
        Console.WriteLine($"{remainingTraps} traps remaining.");
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        Console.WriteLine("Placing traps in storage...");
        PlaceTrap();
    }
}