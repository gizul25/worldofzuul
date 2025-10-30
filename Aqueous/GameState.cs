using Aqueous;

public class GameState {
    public Room CurrentRoom { get; set; }
    public bool ShouldExit = false;

    public GameState(Room currentRoom) {
        this.CurrentRoom = currentRoom;
    }
}