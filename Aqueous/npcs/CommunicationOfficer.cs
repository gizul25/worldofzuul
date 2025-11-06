namespace Aqueous;

public class CommunicationOfficer : NPC {
    public override string GetName() {
        return "Barton";
    }

    public override string GetJobTitle()
    {
        return "Communication's officer";
    }
    
    public override Type GetRoom() {
        return typeof(Communications);
    }
}