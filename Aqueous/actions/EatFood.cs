namespace Aqueous;

public class EatFood : Action {
    public EatFood()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Eat food";
    }

    public override Type GetRoom()
    {
        return typeof(Cafeteria);
    }
    
    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        Console.WriteLine("You grab your daily portion from Joey, muttering a quick thanks and sitting down at a table in the corner.");
        Console.WriteLine("The food tastes like disappointment and regret but you're too hungry to care.");
        Console.WriteLine("You finsih the portion and hand back the plate. The break's over, get back to work.");
    }
}