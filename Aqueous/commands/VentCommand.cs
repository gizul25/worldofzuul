namespace Aqueous;

public class VentCommand : SimpleCommand {
    public override string GetName() {
        return "vent";
    }

    public override void Run(GameState state) {
        if (state.CurrentRoom.Vent != null) {
            string ventExitRoomName = state.CurrentRoom.Vent.GetName();
            Console.WriteLine("Venting to \x1b[36m" + ventExitRoomName + "\x1b[0m");
            Console.WriteLine("");
            state.MoveToRoom(state.CurrentRoom.Vent);
        } else {
            Console.WriteLine("No vent in this room");
        }
    }
}