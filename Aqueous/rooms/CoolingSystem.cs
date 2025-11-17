namespace Aqueous;

public class CoolingSystem : Room
{
    public override string GetName()
    {
        return "Cooling system";
    }

    public override string GetDescription()
    {
        return @"The cooling system, crucial for the reactors maintenance, crucial for the station’s survival. 
The temperature must be stable at all times. Always.";
    }
}