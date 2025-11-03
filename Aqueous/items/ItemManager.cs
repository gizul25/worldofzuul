using Aqueous;

public class ItemManager {
    public List<IItem> Items { get; private set; } = new();

    public void AddItem(IItem item) {
        Items.Add(item);
    }

    public void ConsumeItem(IItem item) {
        Items.Remove(item);
    }
}