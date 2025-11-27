namespace Aqueous.Domain;

public class Sleep : Action
{
    public override string GetName()
    {
        return "Get rest";
    }

    public override Type GetRoom()
    {
        return typeof(SleepingQuarters);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You get into your bed and hope for a peaceful slumber, praying tomorrow will bring something worth living for.");
        state.EndGame();
    }
}