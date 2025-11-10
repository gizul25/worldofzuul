namespace Aqueous;

public class TalkToJoey2 : Action {
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
        // TODO: add dialogue
        Console.WriteLine("");
    }
}