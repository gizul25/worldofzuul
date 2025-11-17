namespace Aqueous;

public class Elevator : Room
{
    public override string GetName()
    {
        return "Elevator";
    }

    public override string GetDescription()
    {
        return @"The elevator, the only thing connecting the station to the surface. 
Very few get to use it and you sometimes wonder what they do up there…";
    }
}