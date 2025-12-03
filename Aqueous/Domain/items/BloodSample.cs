namespace Aqueous.Domain;

public class BloodSample : Item
{
    public override string GetName()
    {
        return "Blood sample";
    }

    public override string GetDescription()
    {
        return "Blood sample from Mickey";
    }
}