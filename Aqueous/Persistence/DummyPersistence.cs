using Aqueous.Domain;

namespace Aqueous.Persistence;

public class DummyPersistence : IPersistence
{

    public DummyPersistence()
    {

    }

    public GameState LoadGameState()
    {
        return new GameState(this);
    }

    public void SaveGameState(GameState gameState)
    {

    }
}