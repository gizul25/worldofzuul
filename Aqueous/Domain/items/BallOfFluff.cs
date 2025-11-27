namespace Aqueous.Domain;

public class BallOfFluff : IItem
{
    public string GetName()
    {
        return "Ball of Fluff";
    }

    public string GetDescription()
    {
        return "Fluffy fur of the local station's cat";
    }
}