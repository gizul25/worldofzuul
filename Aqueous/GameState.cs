namespace Aqueous;

/// Stores all changing parts of the game
public class GameState {
    public Room CurrentRoom { get; private set; }
    public bool ShouldExit = false;
    public bool IsJustEnteredRoom = true;
    public RoomManager roomManager { get; private set; } = new RoomManager();
    public ActionManager actionManager { get; private set; } = new ActionManager();
    public ItemManager itemManager { get; private set; } = new ItemManager();
    public NPCManager npcManager { get; private set; } = new NPCManager();
    public QuestManager questManager { get; private set; } = new QuestManager();

    public GameState() {
        this.CurrentRoom = roomManager.GetStartingRoom();
    }

    public void MoveToRoom(Room room) {
        CurrentRoom = room;
        IsJustEnteredRoom = true;
    }

    public void EndGame() {
        RatTrapStorage ratAction = (RatTrapStorage)actionManager.GetAction<RatTrapStorage>();
        if (ratAction.IsCompleted) {
            Console.WriteLine("You restored the underwater research station back to its former glory. Thank you!");
        } else {
            Console.WriteLine("You went to sleep but rats ate the last bit of underwater protection.");
        }

        ShouldExit = true;
    }
}