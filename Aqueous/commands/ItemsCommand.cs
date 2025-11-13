namespace Aqueous;

public class ItemsCommand : SimpleCommand {
    public override string GetName() {
        return "items";
    }

    public override void Run(GameState state) {
        List<IItem> items = state.itemManager.Items;
        if (items.Count == 0) {
            Console.WriteLine("No items found in inventory.");
            return;
        }

        for (int i = 0; i < items.Count; i++) {
            IItem item = items[i];
            Console.WriteLine($"[\x1b[32m{i + 1}\x1b[0m] \x1b[33m{item.GetName()}\x1b[0m");
            Console.WriteLine(item.GetDescription());
        }
    }
}