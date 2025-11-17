namespace Aqueous;

public class DecontaminateFishSamples : Action
{
    public DecontaminateFishSamples()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Decontaminate fish tanks";
    }

    public override Type GetRoom()
    {
        return typeof(Storage);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Console.WriteLine("These fish tanks look rather dirty and might be contaminated. You should clean them before the fish die.");
        Console.WriteLine("Type \"clean\" five times to clean up the fish tank.");

        int cleanCounter = 0;
        while (cleanCounter < 5)
        {
            string? input = Console.ReadLine();
            if (input != "clean")
            {
                Console.WriteLine("This action doesn't seem to clean up the tanks.");
                continue;
            }
            cleanCounter++;
        }
        Console.WriteLine("The tanks are clean and the glass isn't green from algae anymore. The fish are safe for now.");
        Complete();
    }
}