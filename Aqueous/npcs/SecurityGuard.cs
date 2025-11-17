namespace Aqueous;

public class SecurityGuard : NPC
{
    public override string GetName()
    {
        return "Barry";
    }

    public override string GetJobTitle()
    {
        return "Security Guard";
    }

    public override Type GetRoom()
    {
        return typeof(Security);
    }
}
