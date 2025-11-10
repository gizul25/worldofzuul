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
        Disable();
        state.actionManager.GetAction<FeedMickey>().Enable();
        // TODO: add dialogue
        Console.WriteLine("");
    }
}