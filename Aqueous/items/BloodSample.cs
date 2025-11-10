namespace Aqueous;

public class BloodSample : IItem
{
    public string GetName()
    {
        return "Blood sample";
    }

    public string GetDescription()
    {
        return "Blood sample from Mickey";
    }
}