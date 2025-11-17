namespace Aqueous;

class TalkToViktor : Action
{
    public override string GetName()
    {
        return "Talk to Viktor";
    }
    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Complete();
        Console.WriteLine("Viktor: “Thanks for doing Steve’s part! I swear, he’s probably faking again just to laze around all day!");
        Console.WriteLine("Also, is it me or did the last supplies come with rats as a bonus? I keep finding little teeth marks on the lab equipment!");
        Console.WriteLine("Anyways, since you’re such a good coworker, why don’t you go help Helen in the Main Lab?”");
        state.actionManager.GetAction<RatTrapStorage>().Enable();
        state.actionManager.GetAction<RatTrapShields>().Enable();
        state.actionManager.GetAction<RatTrapDelivery>().Enable();
        state.actionManager.GetAction<RatTrapCoolingSystem>().Enable();
        state.actionManager.GetAction<RatTrapCrewCabin>().Enable();

        state.actionManager.GetAction<DoExperiments>().Enable();
    }
}