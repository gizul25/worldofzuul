namespace Aqueous;

public class CollectMarineFloraSamples : Action
{
    public override string GetName()
    {
        return "Collect marine flora samples";
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
        Console.WriteLine("There's some marine flora samples we have to collect. Type the names of samples to collect them.");
        string[] availableSamples = { "kelp", "seagrass", "green algae", "diatoms", "coraline algae", "fucus", "sea lettuce" };
        Console.WriteLine($"Here are some available samples: {String.Join(", ", availableSamples)}");

        List<string> samples = new List<string>();
        while (samples.Count < 3)
        {
            string? input = Console.ReadLine();
            if (!availableSamples.Contains(input))
            {
                Console.WriteLine("It seems that such sample doesn't exist.");
                continue;
            }
            if (samples.Contains(input!))
            {
                Console.WriteLine("You already have this sample.");
                continue;
            }
            samples.Add(input!);
        }
        Console.WriteLine("Good job! Now you have enough samples to inspect them.");
        Complete();
        state.actionManager.GetAction<UploadResearchData>().Enable();
    }
}