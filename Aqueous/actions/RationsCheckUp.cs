namespace Aqueous;

public class RationsCheckUp : Action
{
    public override string GetName()
    {
        return "Check on rations";
    }

    public override Type GetRoom()
    {
        return typeof(Storage);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You carefully inspect the shelves and boxes. Fortunately nothing seems to be missing or expired.");
        state.actionManager.GetAction<EatFood>().Enable();
    }
}