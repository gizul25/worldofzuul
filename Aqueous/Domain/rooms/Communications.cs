namespace Aqueous.Domain;

public class Communications : Room
{
    public override string GetName()
    {
        return "Communications";
    }

    public override string GetDescription()
    {
        return @"The communication room. 
You think it’s pointless since there is no one to communicate with outside the station. 
Maybe except the mysterious supplier.";
    }
}