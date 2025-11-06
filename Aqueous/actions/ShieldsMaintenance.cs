namespace Aqueous;

public class ShieldMaintenance : OneTimeAction {
    public override string GetName() {
        return "Maintain shields";
    }

    public override Type GetRoom() {
        return typeof(Shields);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Console.WriteLine("Maintaining shields....");
        Console.WriteLine("For your hard work, now you get a security key!");
        state.itemManager.AddItem(new SecurityKey());
    }
}