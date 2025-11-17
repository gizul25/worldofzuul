namespace Aqueous;

public class Socialize : Action
{
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

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You go around the room exchanging tight smiles and pointless small talk. No one's in the mood for deep conversations.");
        state.actionManager.GetAction<IdentifySpecimens>().Enable();
    }
}