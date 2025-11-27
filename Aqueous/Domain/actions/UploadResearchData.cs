namespace Aqueous.Domain;

public class UploadResearchData : Action
{
    public override string GetName()
    {
        return "Upload research data";
    }

    public override Type GetRoom()
    {
        return typeof(Communications);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Console.Write("Enter the upload destination: ");
        string? destination;
        while (true)
        {
            destination = Console.ReadLine();
            if (destination == null || destination == "")
            {
                Console.WriteLine("Destination cannot be empty.");
                continue;
            }
            break;
        }
        Console.Write($"Uploading research data to {destination}.");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Files uploaded successfully.");
        Complete();
    }
}