namespace Aqueous;

public class MedBay : Room
{
    public override string GetName()
    {
        return "MedBay";
    }

    public override string GetDescription()
    {
        return @"The only place in the station focused on something else than endless research and survival. 
The doctor, Bruce, makes sure no one dies. And the job proves harder than it should be…";
    }
}