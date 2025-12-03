namespace Aqueous.Presentation;

using Aqueous.Domain;
using Aqueous.Persistence;

public class Game
{
    private GameState state;

    /// Prints welcome and starts game loop.
    public void Play()
    {
        JSONPersistence persistence = new JSONPersistence("db.json");
        state = persistence.LoadGameState();

        PrintWelcome();

        while (!state.ShouldExit)
        {
            CommandManager.Run(state);
            state.actionManager.UpdateAvailableActions(state);
        }
        state.Save();
        Console.WriteLine("Thank you for playing \x1b[36mAqueous\x1b[0m! Remember to be mindful of your actions unless you want the world to end!");
    }

    /// Prints introductory message at the start of the game
    private static void PrintWelcome()
    {
        Console.WriteLine("Welcome to \x1b[36mAqueous!\x1b[0m");
        Console.WriteLine("Earth has been through a lot in the past few centuries.");
        Console.WriteLine("Now, following the events of World War 5, the surface is completely engulfed in a nuclear winter,");
        Console.WriteLine("surpassing any ice age the world had ever seen before.");
        Console.WriteLine("With the surface uninhabitable, humanity has turned to the underwater world as a last resort.");
        Console.WriteLine("The marine life had been endangered beyond reason in the past, with over 60% of species going extinct.");
        Console.WriteLine("Overfishing, illegal fishing, oil spills, pollution. Everything led to this moment of ruin.");
        Console.WriteLine("Now humanity will do anything to save what was once nearly destroyed.");
        Console.WriteLine("It must be protected as the last surviving natural ecosystem on the planet.");
        Console.WriteLine("And Aqueous is one of the few remaining underwater stations preserving life on Earth.");
        Console.WriteLine("Without it, the waters and society will be one step closer to complete doom...");
        HelpCommand.PrintHelp();
        Console.WriteLine();
    }
}