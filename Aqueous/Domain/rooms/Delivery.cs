namespace Aqueous.Domain;

public class Delivery : Room
{
    public override string GetName()
    {
        return "Delivery";
    }

    public override string GetDescription()
    {
        return @"They don't tell where the provisions come from but no one questions it. 
It’s pointless to ask.";
    }
}