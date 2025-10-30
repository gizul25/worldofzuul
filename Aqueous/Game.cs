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
            Console.WriteLine("Thank you for playing World of Zuul!");
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the World of Zuul!");
            Console.WriteLine("World of Zuul is a new, incredibly boring adventure game.");
            HelpCommand.PrintHelp();
            Console.WriteLine();
        }
    }
}
