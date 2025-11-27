namespace Aqueous.Domain;

public class Reactor : Room
{
    public override string GetName()
    {
        return "Reactor";
    }

    public override string GetDescription()
    {
        return @"The most fragile place on the station. 
A massive reactor stands in the middle, away from anything that could disrupt its peace. 
It’s probably better not to touch it unless absolutely necessary.";
    }
}