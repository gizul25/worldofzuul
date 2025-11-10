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
            Console.WriteLine("Thank you for playing Aqueous!");
        }

        /// Prints introductory message at the start of the game
        private static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Aqueous!");
            Console.WriteLine("Aqueous is an underwater research station game.");
            HelpCommand.PrintHelp();
            Console.WriteLine();
        }
    }
}
