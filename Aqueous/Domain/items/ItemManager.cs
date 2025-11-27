namespace Aqueous.Domain;

public class ItemManager
{
    public List<IItem> Items { get; } = new();

    /// Adds an item to player's inventory
    public void AddItem(IItem item)
    {
        Items.Add(item);
    }

    /// Returns the action given the type of the action
    public T FindItem<T>()
    {
        foreach (IItem item in Items)
        {
            if (item is T)
            {
                return (T)item;
            }
        }
        throw new Exception("Item not found.");
    }

    /// Checks if the user has a given type item in the inventory
    public bool HasItem<T>()
    {
        foreach (IItem item in Items)
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
        IItem item = (IItem)specificItem;
        Items.Remove(item);
    }
}