using Aqueous;

public class GameState {
    public Room CurrentRoom { get; set; }

    public GameState(Room currentRoom) {
        this.CurrentRoom = currentRoom;
    }
}