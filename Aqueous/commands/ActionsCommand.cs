namespace Aqueous;

public class ActionsCommand : SimpleCommand {
    public override string GetName() {
        return "actions";
    }

    public override void Run(GameState state) {
        Room room = state.CurrentRoom;
        List<NPC> npcs = state.npcManager.GetRoomNPCs(room);
        PrintNPCs(npcs);
        Console.WriteLine();

        state.actionManager.PrintAvailableActions();
        if (state.actionManager.AvailableActions.Count > 0) {
            Console.WriteLine("Enter \"\x1b[32mdo <num>\x1b[0m\" to perform the action, e.g. \"\x1b[32mdo 1\x1b[0m\"");
        } else {
            Console.WriteLine("No actions");
        }
    }

    private void PrintNPCs(List<NPC> npcs) {
        if (npcs.Count == 0) {
            Console.WriteLine("No NPCS in this room.");
            return;
        }

        Console.WriteLine("NPCs:");
        foreach (NPC npc in npcs) {
            Console.WriteLine($"- \x1b[33m{npc.GetName()}\x1b[0m (\x1b[36m{npc.GetJobTitle()}\x1b[0m)");
        }
    }
}