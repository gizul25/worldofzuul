using Aqueous.Domain;
using System.Text.Json;

namespace Aqueous.Persistence;

public class JSONPersistence : IPersistence
{
    private string _filePath;
    private JsonSerializerOptions _jsonOptions;

    public JSONPersistence(string filePath)
    {
        _filePath = filePath;
        _jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    }

    public GameState LoadGameState()
    {
        if (!File.Exists(_filePath))
            return new GameState(this);

        string json = File.ReadAllText(_filePath);
        Console.WriteLine(json);
        GameStateSerializable? data = JsonSerializer.Deserialize<GameStateSerializable>(json);
        if (data == null)
        {
            return new GameState(this);
        }

        return data.Deserialize(this);
    }

    public void SaveGameState(GameState gameState)
    {
        GameStateSerializable data = new GameStateSerializable(gameState);
        string json = JsonSerializer.Serialize(data, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }
}