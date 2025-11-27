namespace Aqueous.Presentation;

using Aqueous.Domain;

public class LookCommand : SimpleCommand
{
    public override string GetName()
    {
        return "look";
    }

    public override void Run(GameState state)
    {
        foreach (KeyValuePair<Direction, Room> kvp in state.CurrentRoom.Exits)
        {
            Direction direction = kvp.Key;
            Room room = kvp.Value;

            Console.WriteLine("On the \x1b[33m" + direction + "\x1b[0m: \x1b[36m" + room.GetName() + "\x1b[0m");
        }
    }
}