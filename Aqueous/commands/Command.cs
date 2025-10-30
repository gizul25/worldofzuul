namespace Aqueous;

public abstract class Command {
    public abstract bool TryExecute(string input, GameState state);
}