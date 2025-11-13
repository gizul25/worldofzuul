namespace Aqueous;

public class StoreWaterSamples : Action {
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

    public override void Perform(GameState state) {
        base.Perform(state);
        Console.WriteLine("It's the perfect place for keeping water samples for a long time.");
        Console.Write("Putting water samples in cold storage...");
        for (int i = 0; i < 3; i++) {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Done!");
        Complete();
    }
}