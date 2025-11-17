namespace Aqueous;

public class SeniorLabManager : NPC
{
    public override string GetName()
    {
        return "Claire";
    }

    public override string GetJobTitle()
    {
        return "Senior Lab Manager";
    }

    public override Type GetRoom()
    {
        return typeof(MainLab);
    }
}