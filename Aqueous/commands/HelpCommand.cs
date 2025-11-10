namespace Aqueous;

public class HelpCommand : SimpleCommand {
    public override string GetName() {
        return "help";
    }

    public override void Run(GameState state) {
        PrintHelp();
    }

    public static void PrintHelp() {
        Console.WriteLine("You are lost. You are alone. You wander");
        Console.WriteLine("around the university.");
        Console.WriteLine();
        Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");
        Console.WriteLine("Type 'look' for more details.");
        Console.WriteLine("Type 'vent' to vent in some of the rooms.");
        Console.WriteLine("Type 'actions' to get actions available in the room.");
        Console.WriteLine("Type 'quests' to current quests.");
        Console.WriteLine("Type 'items' to list items in your inventory.");
        Console.WriteLine("Type 'map' to print a map of the underwater research station.");
        Console.WriteLine("Type 'help' to print this message again.");
        Console.WriteLine("Type 'quit' to exit the game.");
    }
}