namespace Aqueous
{
    public class Game
    {
        private GameState state = new GameState();

        /// Prints welcome and starts game loop.
        public void Play()
        {
            PrintWelcome();

            while (!state.ShouldExit) {
                CommandManager.Run(state);
                state.actionManager.UpdateAvailableActions(state);
            }
            Console.WriteLine("Thank you for playing Aqueous! Remember to be mindful of your actions unless you want to end up like Steve!");
        }

        /// Prints introductory message at the start of the game
        private static void PrintWelcome()
        {
            Console.WriteLine("Welcome to Aqueous!");
            Console.WriteLine("Earth has been through a lot.");
            Console.WriteLine("Now, following the events of World War 5, the surface is completely engulfed in a nuclear winter, surpassing any ice age the world had ever seen before.");
            Console.WriteLine("With the surface unhabitable, humanity has turned to what's underwater as a last resort.");
            Console.WriteLine("Aqueous is one of the last underwater stations preserving life on Earth.");
            Console.WriteLine("Without it, society will be one step closer to complete doom...");
            HelpCommand.PrintHelp();
            Console.WriteLine();
        }
    }
}
