namespace Aqueous;

public class Electrician : NPC
{
    public override string GetName() {
        return "Joseph";
    }

    public override string GetJobTitle()
    {
        return "Electrician";
    }

    public override Type GetRoom() {
        return typeof(Electrical);
    }

}