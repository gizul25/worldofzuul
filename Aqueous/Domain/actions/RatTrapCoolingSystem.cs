namespace Aqueous.Domain;

public class RatTrapCoolingSystem : Action
{
    public override string GetName()
    {
        return "Setup rat trap";
    }

    public override Type GetRoom()
    {
        return typeof(CoolingSystem);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("Placing traps in cooling system...");

        RatTrapStorage ratTrapStorage = (RatTrapStorage)
            state.actionManager.GetAction<RatTrapStorage>();
        ratTrapStorage.PlaceTrap();
    }
}