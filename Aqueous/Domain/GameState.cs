using Aqueous.Persistence;

namespace Aqueous.Domain;

/// Stores all changing parts of the game
public class GameState
{
    public Room CurrentRoom { get; private set; }
    public bool ShouldExit = false;
    public bool IsJustEnteredRoom = true;
    public RoomManager roomManager { get; } = new RoomManager();
    public ActionManager actionManager { get; } = new ActionManager();
    public ItemManager itemManager { get; } = new ItemManager();
    public NPCManager npcManager { get; } = new NPCManager();
    public QuestManager questManager { get; } = new QuestManager();

    private IPersistence persistence;

    public GameState(IPersistence persistence)
    {
        this.CurrentRoom = roomManager.GetStartingRoom();
        this.persistence = persistence;
    }

    public GameState(IPersistence persistence, String roomName, ActionManager actionManager, ItemManager itemManager)
    {
        Type roomType = Type.GetType(roomName)!;
        this.CurrentRoom = roomManager.GetRoom(roomType);
        this.actionManager = actionManager;
        this.itemManager = itemManager;
        this.persistence = persistence;
    }

    public void Save()
    {
        persistence.SaveGameState(this);
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