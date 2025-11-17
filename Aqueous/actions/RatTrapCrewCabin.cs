namespace Aqueous;

public class RatTrapCrewCabin : Action
{
    public RatTrapCrewCabin()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Setup rat trap";
    }

    public override Type GetRoom()
    {
        return typeof(CrewCabin);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("Placing traps in crew cabin...");

        RatTrapStorage ratTrapStorage = (RatTrapStorage)
            state.actionManager.GetAction<RatTrapStorage>();
        ratTrapStorage.PlaceTrap();
    }
}