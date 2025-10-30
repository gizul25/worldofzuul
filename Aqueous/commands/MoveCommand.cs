using Aqueous;

public class MoveCommand : Command {
    public override bool TryExecute(string input, GameState state) {
        try {
            Direction direction = DirectionHelper.DirectionFromString(input);
            Run(state, direction);
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public void Run(GameState state, Direction direction) {
        if (!state.CurrentRoom.Exits.ContainsKey(direction)) {
            Console.WriteLine($"You can't go {direction}!");
            return;
        }

        state.CurrentRoom = state.CurrentRoom.Exits[direction];
    }
}