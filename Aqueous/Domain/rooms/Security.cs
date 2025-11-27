namespace Aqueous.Domain;
public class Security : Room
{
    public override string GetName()
    {
        return "Security";
    }
    public override string GetDescription()
    {
        return @"This is a Security Room. Well, at least an excuse for it. 
Not like anyone’s going to steal some fossils in a world that's hanging on a thread.";
    }
}