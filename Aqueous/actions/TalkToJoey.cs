namespace Aqueous;

public class TalkToJoey : Action {
    public TalkToJoey() {
        Enable();
    }

    public override string GetName() {
        return "Talk to Joey";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }
    
    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        state.actionManager.GetAction<FixWiringAction>().Enable();
        Console.WriteLine("Joey:“Oh! Good thing you’re here! See, the stove’s been actin’ out real bad lately.");
        Console.WriteLine("It’s been growlin’ at me every time I try to do anythin’, I’m startin’ to think it’s possessed!");
        Console.WriteLine("Why don’t ya go ahead and check the wires for me, huh?”");
    }
}