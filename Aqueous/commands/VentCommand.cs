using Aqueous;

public class VentCommand : SimpleCommand {
    public override string GetName() {
        return "vent";
    }

    public override void Run(GameState state) {
        if (state.CurrentRoom.Vent != null) {
            string ventExitRoomName = state.CurrentRoom.Vent.GetName();
            Console.WriteLine("Venting to " + ventExitRoomName);
            state.CurrentRoom = state.CurrentRoom.Vent;
        } else {
            Console.WriteLine("No vent in this room");
        }
    }
}