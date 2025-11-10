namespace Aqueous;

public class TalkToJoey2 : Action {
    public TalkToJoey2()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Talk to Joey 2";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        state.actionManager.GetAction<FeedTheCat>().Enable();
        state.itemManager.AddItem(new Leftovers());
        Console.WriteLine("Joey:“Ya fixed it? My, my, so fast! And my boy's workin' better than ever, no growlin' no nothin'. Here, take this as a little thanks. Maybe give it to the little fluff man over there.”");
    }
}