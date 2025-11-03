namespace Aqueous;

public class LookCommand : SimpleCommand {
    public override string GetName() {
        return "look";
    }

    public override void Run(GameState state) {
        foreach (KeyValuePair<Direction, Room> kvp in state.CurrentRoom.Exits) {
            Direction direction = kvp.Key;
            Room room = kvp.Value;

            Console.WriteLine("On the " + direction + ": " + room.GetName());
        }
    }
}