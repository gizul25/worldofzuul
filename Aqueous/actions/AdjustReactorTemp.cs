namespace Aqueous;

public class AdjustReactorTemp : Action
{
    public AdjustReactorTemp()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Adjust reactor temperature";
    }

    public override Type GetRoom()
    {
        return typeof(Reactor);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Console.WriteLine("It seems that reactor is now at 1200 degrees but it should be exactly 1100 degrees! Enter \"+\" or \"-\" to change reactor temperature by 10 degrees.");

        int reactorTemp = 1200;
        while (reactorTemp != 1100)
        {
            string? input = Console.ReadLine();
            if (input == "+")
            {
                reactorTemp += 10;
            }
            else if (input == "-")
            {
                reactorTemp -= 10;
            }
            else
            {
                Console.WriteLine("It seems this command has no effect to reactor's temperature.");
                continue;
            }
            Console.WriteLine($"Reactor's temperature: {reactorTemp}");
        }
        Console.WriteLine("The reactor is back to it's stable state. Crisis averted.");
        Complete();
    }
}