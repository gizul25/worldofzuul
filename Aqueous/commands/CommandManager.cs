using Aqueous;

public class CommandManager {
    private static Command[] commands = [
        new HelpCommand(),
        new LookCommand(),
        new MoveCommand(),
        new QuitCommand()
    ];
    
    public static bool Run(GameState state) {
        Console.WriteLine(state.CurrentRoom.GetDescription());
        Console.Write("> ");

        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Please enter a command.");
            return true;
        }

        foreach (Command command in commands) {
            if (command.TryExecute(input, state)) {
                return true;
            }
        }

        Console.WriteLine("Invalid command.");
        return true;
    }
}