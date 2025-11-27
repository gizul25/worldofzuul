namespace Aqueous;

public abstract class SimpleCommand : Command
{
    /// Runs the command only if the input matches command name
    public override bool TryExecute(string input, GameState state)
    {
        if (input != GetName())
        {
            return false;
        }

        Run(state);
        return true;
    }

    /// Returns the command name used to compare to the user input
    public virtual string GetName()
    {
        return "unimplemented";
    }

    /// Executes the command
    public virtual void Run(GameState state) { }
}