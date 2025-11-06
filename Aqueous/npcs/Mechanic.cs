namespace Aqueous;

public class Mechanic : NPC {
    public override string GetName() {
        return "Mike";
    }

    public override string GetJobTitle()
    {
        return "Mechanic";
    }
    
    public override Type GetRoom() {
        return typeof(Reactor);
    }
}