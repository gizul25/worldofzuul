using System.Text.Json.Serialization;

namespace Aqueous.Domain;

public class ItemManager
{
    [JsonInclude]
    public List<Item> Items = new();

    /// Adds an item to player's inventory
    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    /// Returns the action given the type of the action
    public T FindItem<T>()
    {
        foreach (Item item in Items)
        {
            if (item is T t)
            {
                return t;
            }
        }
        throw new Exception("Item not found.");
    }

    /// Checks if the user has a given type item in the inventory
    public bool HasItem<T>()
    {
        foreach (Item item in Items)
        {
            if (item is T)
            {
                return true;
            }
        }
        return false;
    }

    /// Removes a given type item from player's inventory
    public void ConsumeItem<T>()
    {
        // Have to do this specific pattern so that it doesn't throw
        // null warnings even though it is unreachable.
        T specificItem = FindItem<T>();
        if (specificItem == null)
        {
            throw new Exception("Item not found.");
        }
        Item? item = specificItem as Item;
        Items.Remove(item!);
    }
}