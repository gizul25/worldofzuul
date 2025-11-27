namespace Aqueous;

/// Stores all changing parts of the game
public class GameState
{
    public Room CurrentRoom { get; }
    public bool ShouldExit = false;
    public bool IsJustEnteredRoom = true;
    public RoomManager roomManager { get; } = new RoomManager();
    public ActionManager actionManager { get; } = new ActionManager();
    public ItemManager itemManager { get; } = new ItemManager();
    public NPCManager npcManager { get; } = new NPCManager();
    public QuestManager questManager { get; } = new QuestManager();

    public GameState()
    {
        this.CurrentRoom = roomManager.GetStartingRoom();
    }

    /// Moves the player to a different room
    public void MoveToRoom(Room room)
    {
        CurrentRoom = room;
        IsJustEnteredRoom = true;
    }

    /// Handles multiple endings, used when the player completes the game fully,
    /// not for 'quit' command.
    public void EndGame()
    {
        RatTrapStorage ratAction = (RatTrapStorage)actionManager.GetAction<RatTrapStorage>();
        if (ratAction.IsCompleted)
        {
            Console.WriteLine("You managed to maintain the underwater research station in a decent state. Hopefully everything gets better from here on.");
        }
        else
        {
            Console.WriteLine("You went to sleep wihtout doing your job. The rats ate through important wires and the station's systems collapsed. Everyone died because of your negligence.");
        }

        ShouldExit = true;
    }
}