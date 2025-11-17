namespace Aqueous;

public class StationBiologist : NPC
{
    public override string GetName()
    {
        return "Helen";
    }

    public override string GetJobTitle()
    {
        return "Station Biologist";
    }

    public override Type GetRoom()
    {
        return typeof(MainLab);
    }
}
