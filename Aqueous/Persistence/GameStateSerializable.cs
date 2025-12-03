using System.Text.Json.Serialization;
using Aqueous.Domain;

namespace Aqueous.Persistence;

public class GameStateSerializable
{
    [JsonInclude]
    public string CurrentRoom { get; set; } = "";
    [JsonInclude]
    public bool IsJustEnteredRoom { get; set; } = true;
    [JsonInclude]
    public ActionManager actionManager { get; set; } = new ActionManager();
    [JsonInclude]
    public ItemManager itemManager { get; set; } = new ItemManager();

    public GameStateSerializable()
    {

    }

    public GameStateSerializable(GameState gameState)
    {
        CurrentRoom = gameState.CurrentRoom.GetType().ToString();
        IsJustEnteredRoom = gameState.IsJustEnteredRoom;
        actionManager = gameState.actionManager;
        itemManager = gameState.itemManager;
    }

    public GameState Deserialize(IPersistence persistence)
    {
        GameState gameState = new GameState(persistence, CurrentRoom, actionManager, itemManager);
        gameState.IsJustEnteredRoom = IsJustEnteredRoom;
        return gameState;
    }
}