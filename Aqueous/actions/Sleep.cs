namespace Aqueous;

public class Sleep : Action {
    public override string GetName() {
        return "Get rest";
    }

    public override Type GetRoom()
    {
        return typeof(SleepingQuarters);
    }
    
    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        Console.WriteLine("Sleeping....");
    }
}