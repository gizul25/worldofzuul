namespace Aqueous;

public class ItemManager {
    public List<IItem> Items { get; private set; } = new();

    public void AddItem(IItem item) {
        Items.Add(item);
    }

    public T FindItem<T>() {
        foreach(IItem item in Items) {
            if (item is T) {
                return (T)item;
            }
        }
        throw new Exception("Item not found.");
    }

    public bool HasItem<T>() {
        foreach(IItem item in Items) {
            if (item is T) {
                return true;
            }
        }
        return false;
    }

    public void ConsumeItem<T>() {
        // Have to do this specific pattern so that it doesn't throw
        // null warnings even though it is unreachable.
        T specificItem = FindItem<T>();
        if (specificItem == null) {
            throw new Exception("Item not found.");
        }
        IItem item = (IItem)specificItem;
        Items.Remove(item);
    }

    public void ConsumeItem(IItem item) {
        Items.Remove(item);
    }
}