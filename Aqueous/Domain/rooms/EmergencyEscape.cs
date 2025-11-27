namespace Aqueous.Domain;
public class EmergencyExit : Room
{
    public override string GetName()
    {
        return "Emergency Exit";
    }
    public override string GetDescription()
    {
        return @"The emergency escape – the plan B in case everything goes to hell. 
You pray you will never have to use it…";
    }
}