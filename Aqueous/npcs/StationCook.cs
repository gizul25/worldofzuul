namespace Aqueous;

public class StationCook : NPC {
    public override string GetName() {
        return "Joey";
    }

    public override string GetJobTitle()
    {
        return "Station cook";
    }
    
    public override Type GetRoom() {
        return typeof(Cafeteria);
    }
}