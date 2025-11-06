namespace Aqueous;

public class StorageManager : NPC {
    public override string GetName() {
        return "Larry";
    }

    public override string GetJobTitle()
    {
        return "Storage manager";
    }
    
    public override Type GetRoom() {
        return typeof(Storage);
    }
}