namespace Aqueous;

public abstract class Command {
    /// Function used to attempt to execute the function given raw text input
    /// and state. Return value indicates if command ran successfully, true
    /// if it completed successfully, false if input is invalid.
    public abstract bool TryExecute(string input, GameState state);
}