namespace Aqueous.Presentation;

using Aqueous.Domain;

public class MoveCommand : Command
{
    public override bool TryExecute(string input, GameState state)
    {
        try
        {
            Direction direction = DirectionHelper.DirectionFromString(input);
            Run(state, direction);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public void Run(GameState state, Direction direction)
    {
        if (!state.CurrentRoom.Exits.ContainsKey(direction))
        {
            Console.WriteLine($"You can't go {direction}!");
            return;
        }

        state.MoveToRoom(state.CurrentRoom.Exits[direction]);
    }
}