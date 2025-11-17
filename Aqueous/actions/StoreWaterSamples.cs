namespace Aqueous;

public class StoreWaterSamples : Action
{
    public StoreWaterSamples()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Store water samples";
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
        Console.WriteLine("Due to the maintained low temperature of the cooling system it's the best place to preserve water samples for extended periods of time.");
        Console.Write("You walk over to a special cabinet in the corner, open its door and carefully put the samples inside before closing the door.");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("The samples are safe and cold, ready to be researched in the future.");
        Complete();
    }
}