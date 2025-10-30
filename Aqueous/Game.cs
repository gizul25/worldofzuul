namespace Aqueous
{
    public class Game
    {
        private GameState state;
        private Command[] commands = [
            new HelpCommand(),
            new LookCommand(),
            new MoveCommand()
        ];

        public Game()
        {
            CreateRooms();
        }

        private void CreateRooms()
        {
            Room crewCabin = new CrewCabin();
            state = new GameState(crewCabin);
        }

        public bool Tick() {
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

        public void Play()
        {
            PrintWelcome();

            while (Tick()) {}
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
