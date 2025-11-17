namespace Aqueous;

public class SoftwareEngineer : NPC
{
    public override string GetName()
    {
        return "Bob";
    }

    public override string GetJobTitle()
    {
        return "Software Engineer";
    }

    public override Type GetRoom()
    {
        return typeof(Security);
    }
}