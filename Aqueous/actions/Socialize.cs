namespace Aqueous;

public class Socialize : Action {
    public Socialize()
    {
        Enable();
    }
    
    public override string GetName()
    {
        return "Socialize";
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
        Console.WriteLine("Socializing....");
    }
}