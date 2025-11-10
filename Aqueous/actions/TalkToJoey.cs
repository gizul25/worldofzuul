namespace Aqueous;

public class TalkToJoey : Action {
    public override string GetName() {
        return "Talk to Joey";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("“Oh! Good thing you’re here! See, the stove’s been actin’ out real bad lately. It’s been growlin’ at me every time I try to do anythin’, I’m startin’ to think it’s possessed! Why don’t ya go ahead and check the wires for me, huh?”");
    }
}