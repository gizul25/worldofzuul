namespace Aqueous;

public class EatFood : Action {
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
        Disable();
        Console.WriteLine("Eating food....");
    }
}