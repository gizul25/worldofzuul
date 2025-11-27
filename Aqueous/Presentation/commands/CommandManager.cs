namespace Aqueous.Presentation;

using Aqueous.Domain;

public class CommandManager
{
    private static Command[] commands = [
        new HelpCommand(),
        new LookCommand(),
        new MoveCommand(),
        new QuitCommand(),
        new ActionsCommand(),
        new DoCommand(),
        new VentCommand(),
        new ItemsCommand(),
        new QuestsCommand(),
        new MapCommand()
    ];

    /// Waits for the user input and executes the command
    public static void Run(GameState state)
    {
        if (state.IsJustEnteredRoom)
        {
            Console.WriteLine(state.CurrentRoom.GetDescription());
            state.IsJustEnteredRoom = false;
        }
        Console.Write("\x1b[32m> ");
        Console.Write("\x1b[0m");

        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Please enter a command.");
            return;
        }

        foreach (Command command in commands)
        {
            if (command.TryExecute(input, state))
            {
                return;
            }
        }

        Console.WriteLine("Invalid command.");
    }
}