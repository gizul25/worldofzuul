namespace Aqueous;

public class FeedTheCat : Action {
    public FeedTheCat()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Feed the cat";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override bool IsActive(GameState state) {
        if (!base.IsActive(state)) {
            return false;
        }
        if (!state.itemManager.HasItem<Leftovers>()) {
            return false;
        }
        return true;
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        state.itemManager.ConsumeItem<Leftovers>();
        Console.WriteLine("Good job, you got the ball of fluff to like you more. Beware of jealous researchers...");
    }
}