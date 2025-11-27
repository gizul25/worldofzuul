namespace Aqueous.Domain;

public class FeedMickey : Action
{
    public override string GetName()
    {
        return "Feed Mickey the Bonnethead Shark";
    }

    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }

    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("You cautiously approach the tank and open the top lid, making sure your fingers are out of biting range.");
        Console.WriteLine("You reach into the bucket and grab a handful of small fish before throwing them into the tank.");
        Console.WriteLine("Once the bucket's empty, you close the lid and set the bucket down, watching Mickey devour the poor fishies.");
        Console.WriteLine("You hear Viktor coming behind you.");
        Console.WriteLine("The job is done. You should probably talk to Viktor.");
        state.actionManager.GetAction<TalkToViktor>().Enable();
        state.actionManager.GetAction<CheckCoralReefStatus>().Enable();
    }
}