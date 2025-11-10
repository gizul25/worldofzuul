namespace Aqueous;

public class FeedMickey : Action
{
    public FeedMickey()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Feed Mickey the Bonnethead Shark";
    }

    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Disable();
        Console.WriteLine("You cautiously approach the tank and open the top lid, making sure your fingers are out of biting range. You reach into the bucket and grab a handfull of small fish before throwing them into the tank. Once the bucket's empty, you close the lid and set the bucket down, watching Mickey devour the poor fishies. You hear Viktor coming behind you.");
        Console.WriteLine("Viktor: “Thanks for doing Steve’s part! I swear, he’s probably faking again just to laze around all day! Also, is it me or did the last supplies come with rats as a bonus? I keep finding little teeth marks on the lab equipment! Anyways, since you’re such a good coworker, why don’t you go help Helen?”");
        
        state.actionManager.GetAction<RatTrapStorage>().Enable();
        state.actionManager.GetAction<RatTrapShields>().Enable();
        state.actionManager.GetAction<RatTrapDelivery>().Enable();
        state.actionManager.GetAction<RatTrapCoolingSystem>().Enable();
        state.actionManager.GetAction<RatTrapCrewCabin>().Enable();
    }
}