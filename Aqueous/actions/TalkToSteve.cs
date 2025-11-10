namespace Aqueous;

public class TalkToSteve : Action {
    public TalkToSteve() {
        Enable();
    }

    public override string GetName() {
        return "Talk to Steve";
    }

    public override Type GetRoom() {
        return typeof(MedBay);
    }
    
    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        state.actionManager.GetAction<FeedMickey>().Enable();
        Console.WriteLine("Steve:“Hey, my man! See, I'm very sick, have a terrible headache and everything, I don't think I can do my part today. You can do the works, right? Thanks, I owe you big time!”");
    }
}