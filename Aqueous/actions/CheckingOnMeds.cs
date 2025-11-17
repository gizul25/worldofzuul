namespace Aqueous;

public class CheckingOnMeds : Action
{
    public override string GetName()
    {
        return "Check on medical equipment";
    }

    public override Type GetRoom()
    {
        return typeof(MedBay);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You carefully inspect the machines in the room.");
        Console.WriteLine("Except for a few scratches and blood stains everything seems to be fine.");
    }
}