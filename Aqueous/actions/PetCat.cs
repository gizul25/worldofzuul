namespace Aqueous;

public class PetCat : Action
{
    public override string GetName()
    {
        return "Pet the Cat";
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
        Console.WriteLine("You reach out and pet Leonardo's head, a rare smile on your lips as the cat purrs and nuzzles into your hand.");
    }
}