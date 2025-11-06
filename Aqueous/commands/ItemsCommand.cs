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
            Console.WriteLine($"[{i + 1}] {item.GetName()}");
            Console.WriteLine(item.GetDescription());
        }
    }
}