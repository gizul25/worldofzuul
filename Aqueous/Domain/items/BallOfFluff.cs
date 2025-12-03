namespace Aqueous.Domain;

public class BallOfFluff : Item
{
    public override string GetName()
    {
        return "Ball of Fluff";
    }

    public override string GetDescription()
    {
        return "Fluffy fur of the local station's cat";
    }
}