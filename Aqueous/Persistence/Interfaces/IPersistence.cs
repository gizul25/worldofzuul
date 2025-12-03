using Aqueous.Domain;

namespace Aqueous.Persistence;

public interface IPersistence
{
    GameState LoadGameState();
    void SaveGameState(GameState gameState);
}