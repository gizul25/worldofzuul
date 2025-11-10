namespace Aqueous;

public class FixWiringAction : Action {
    public FixWiringAction()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Fix wiring";
    }

    public override Type GetRoom() {
        return typeof(Electrical);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        Console.WriteLine("You carefully inspect the wires, discovering a bunch of tiny teeth marks. Some animal must've bit through. Or Steve. Let's hope it wasn't Steve. With cautious precision you remove the severed wires and replace them with new ones. Job done, time to get back to Joey.");
        state.actionManager.GetAction<TalkToJoey2>().Enable();
    }
}