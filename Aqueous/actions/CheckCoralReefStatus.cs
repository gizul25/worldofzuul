namespace Aqueous;

public class CheckCoralReefStatus : Action {
    public CheckCoralReefStatus()
    {
        Enable();
    }
    
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
        return typeof(SideQuests);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Console.Write("Checking coral reef status...");
        for (int i = 0; i < 3; i++) {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Oh no, it seems that coral reefs are deteriorating due to high levels of water pollution.");
        Complete();
    }
}