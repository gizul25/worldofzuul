namespace Aqueous;

public class RatTrapShields : Action
{
    public RatTrapShields()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Setup rat trap";
    }

    public override Type GetRoom()
    {
        return typeof(Shields);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("Placing traps in shields...");

        RatTrapStorage ratTrapStorage = (RatTrapStorage)
            state.actionManager.GetAction<RatTrapStorage>();
        ratTrapStorage.PlaceTrap();
    }
}