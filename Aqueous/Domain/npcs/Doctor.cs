namespace Aqueous.Domain;

public class Doctor : NPC
{
    public override string GetName()
    {
        return "Bruce";
    }

    public override string GetJobTitle()
    {
        return "Doctor";
    }

    public override Type GetRoom()
    {
        return typeof(MedBay);
    }

}