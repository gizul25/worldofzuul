namespace Aqueous.Domain;

public class ShieldMaintenance : Action
{
    public ShieldMaintenance()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Maintain shields";
    }

    public override Type GetRoom()
    {
        return typeof(Shields);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You approach the massive machine in the center of the room and access the system.");
        Console.WriteLine("Everything seems to be in working order but you order a shields check just in case.");
        Console.WriteLine("It comes out positive, the station is safe. At least from external dangers.");
        Console.WriteLine("For your hard work, now you get a security key!");
        state.itemManager.AddItem(new SecurityKey());
        state.actionManager.GetAction<SecurityCheck>().Enable();
    }
}