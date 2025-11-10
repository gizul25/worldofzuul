namespace Aqueous;

public class RatTrapDelivery : Action {
    public override string GetName() {
        return "Setup rat trap";
    }

    public override Type GetRoom() {
        return typeof(Delivery);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        Console.WriteLine("Placing traps in delivery...");
        
        RatTrapStorage ratTrapStorage = (RatTrapStorage)
            state.actionManager.GetAction<RatTrapStorage>();
        ratTrapStorage.PlaceTrap();
    }
}