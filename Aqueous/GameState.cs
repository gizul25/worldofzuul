namespace Aqueous;

public class GameState {
    public Room CurrentRoom { get; set; }
    public bool ShouldExit = false;
    public ActionManager actionManager = new ActionManager();
    public ItemManager itemManager = new ItemManager();
    public NPCManager npcManager = new NPCManager();

    public GameState(Room currentRoom) {
        this.CurrentRoom = currentRoom;
    }
}