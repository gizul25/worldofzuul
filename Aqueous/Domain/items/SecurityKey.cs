namespace Aqueous.Domain;

public class SecurityKey : Item
{
    public override string GetName()
    {
        return "Security key";
    }

    public override string GetDescription()
    {
        return "Unlocks access to security cameras";
    }
}