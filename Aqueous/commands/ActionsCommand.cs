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
            Console.WriteLine("Enter \"do <num>\" to perform the action, e.g. \"do 1\"");
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
            Console.WriteLine($"- {npc.GetName()} ({npc.GetJobTitle()})");
        }
    }
}