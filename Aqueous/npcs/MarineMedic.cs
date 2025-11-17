namespace Aqueous;

public class MarineMedic : NPC
{
    public override string GetName()
    {
        return "Viktor";
    }

    public override string GetJobTitle()
    {
        return "Medic - marine";
    }

    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }
}