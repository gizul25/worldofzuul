namespace Aqueous;

public class HelpCommand : SimpleCommand {
    public override string GetName() {
        return "help";
    }

    public override void Run(GameState state) {
        PrintHelp();
    }

    public static void PrintHelp() {
        Console.WriteLine("You're one of the station's main technicians but the job title is just a cover since you often end");
        Console.WriteLine("up doing more than just tech stuff. You never complain though. The risk isn't worth it.");
        Console.WriteLine("Another day in your miserable work life starts. Do your job and make sure the station does't explode.");
        Console.WriteLine("Perform the tasks given to you or don't. Regardless, your choices will have consequences.");
        Console.WriteLine("Remember that.");
        Console.WriteLine("Good luck.");
        Console.WriteLine("Navigate the station by typing 'north', 'south', 'east', or 'west'.");
        Console.WriteLine("Type 'look' for more details.");
        Console.WriteLine("Type 'vent' to vent in some of the rooms.");
        Console.WriteLine("Type 'actions' to get actions available in the room.");
        Console.WriteLine("Type 'quests' to see current quests.");
        Console.WriteLine("Type 'items' to list items in your inventory.");
        Console.WriteLine("Type 'map' to print a map of the station.");
        Console.WriteLine("Type 'help' to print this message again.");
        Console.WriteLine("Type 'quit' to exit the game.");
    }
}