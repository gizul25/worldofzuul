namespace Aqueous;

public class Sleep : Action {
    public Sleep() {
        Enable();
    }

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
        Complete();
        Console.WriteLine("Sleeping....");
        state.EndGame();
    }
}