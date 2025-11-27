namespace Aqueous.Domain;

public class Leftovers : IItem
{
    public string GetName()
    {
        return "Leftovers from Joey";
    }

    public string GetDescription()
    {
        return "Bits and pieces of yesterday's dinner. Something a certain fluff ball would love to get its paws on.";
    }
}