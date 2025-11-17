namespace Aqueous;

public class SickResearcher : NPC
{
    public override string GetName()
    {
        return "Steve";
    }

    public override string GetJobTitle()
    {
        return "Researcher";
    }

    public override Type GetRoom()
    {
        return typeof(MedBay);
    }
}