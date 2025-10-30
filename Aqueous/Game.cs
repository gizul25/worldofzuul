namespace Aqueous
{
    public class Game
    {
        private GameState state;

        public Game()
        {
            Room startingRoom = RoomManager.CreateRooms();
            state = new GameState(startingRoom);
        }

        public void Play()
        {
            PrintWelcome();

            while (CommandManager.Run(state)) {}
            Console.WriteLine("Thank you for playing Aqueous!");
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Aqueous!");
            Console.WriteLine("Aqueous is an underwater research station game.");
            HelpCommand.PrintHelp();
            Console.WriteLine();
        }
    }
}
