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
        Console.WriteLine("\x1b[33mGood luck!\x1b[0m");
        Console.WriteLine();
        Console.WriteLine("Navigate the station by typing '\x1b[32mnorth\x1b[0m', '\x1b[32msouth\x1b[0m', '\x1b[32meast\x1b[0m', or '\x1b[32mwest\x1b[0m'.");
        Console.WriteLine("Type '\x1b[32mlook\x1b[0m' for more details.");
        Console.WriteLine("Type '\x1b[32mvent\x1b[0m' to vent in some of the rooms.");
        Console.WriteLine("Type '\x1b[32mactions\x1b[0m' to get actions available in the room.");
        Console.WriteLine("Type '\x1b[32mquests\x1b[0m' to see current quests.");
        Console.WriteLine("Type '\x1b[32mitems\x1b[0m' to list items in your inventory.");
        Console.WriteLine("Type '\x1b[32mmap\x1b[0m' to print a map of the station.");
        Console.WriteLine("Type '\x1b[32mhelp\x1b[0m' to print this message again.");
        Console.WriteLine("Type '\x1b[32mquit\x1b[0m' to exit the game.");
    }
}