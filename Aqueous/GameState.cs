namespace Aqueous;

/// Stores all changing parts of the game
public class GameState {
    public Room CurrentRoom;
    public bool ShouldExit = false;
    public ActionManager actionManager { get; private set; } = new ActionManager();
    public ItemManager itemManager { get; private set; } = new ItemManager();
    public NPCManager npcManager { get; private set; } = new NPCManager();
    public QuestManager questManager { get; private set; } = new QuestManager();

    public GameState(Room currentRoom) {
        this.CurrentRoom = currentRoom;
    }
}