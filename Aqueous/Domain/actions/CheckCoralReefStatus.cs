namespace Aqueous.Domain;

public class CheckCoralReefStatus : Action
{
    public override string GetName()
    {
        return "Check coral reef status";
    }

    public override Type GetRoom()
    {
        return typeof(Communications);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Console.Write("Checking coral reef status...");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("It seems like the nearby coral reefs are deteriorating due to high levels of water pollution. You should include it in the next report.");
        Complete();
        state.actionManager.GetAction<DecontaminateFishSamples>().Enable();
    }
}