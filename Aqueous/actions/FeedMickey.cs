namespace Aqueous;

public class FeedMickey : Action
{
    public FeedMickey()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Feed Mickey the Bonnethead Shark";
    }

    public override Type GetRoom()
    {
        return typeof(MedBay);
    }
    public override void Perform(GameState state)
    {
        base.Perform(state);
        Disable();
        Console.WriteLine("Feeding Mickey...");
        Console.WriteLine("Done!");
    }
}