namespace Aqueous.Domain;

public class Janitor : NPC
{
    public override string GetName()
    {
        return "Patrick";
    }

    public override string GetJobTitle()
    {
        return "Janitor";
    }

    public override Type GetRoom()
    {
        return typeof(SleepingQuarters);
    }
}