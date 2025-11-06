namespace Aqueous;

public class StationCat : NPC {
    public override string GetName() {
        return "Leonardo DiCarpio";
    }

    public override string GetJobTitle()
    {
        return "Station Cat";
    }
    
    public override Type GetRoom() {
        return typeof(SleepingQuarters);
    }
}