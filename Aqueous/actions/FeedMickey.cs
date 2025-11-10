namespace Aqueous;

public class FeedMickey : Action
{
    public override string GetName()
    {
        return "Feed Mickey the Bonnethead Shark";
    }

    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Disable();
        Console.WriteLine("Feeding Mickey...");
        Console.WriteLine("Done!");

        // TODO: better description and mention something about rats
        state.actionManager.GetAction<RatTrapStorage>().Enable();
        state.actionManager.GetAction<RatTrapShields>().Enable();
        state.actionManager.GetAction<RatTrapDelivery>().Enable();
        state.actionManager.GetAction<RatTrapCoolingSystem>().Enable();
        state.actionManager.GetAction<RatTrapCrewCabin>().Enable();
    }
}