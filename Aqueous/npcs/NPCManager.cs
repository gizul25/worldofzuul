namespace Aqueous;

public class NPCManager {
    private static NPC[] npcs = [
        // TODO: fill it in
        new SecurityGuard(),
    ];

    public List<NPC> GetRoomNPCs(Room room) {
        List<NPC> roomNPCs = new List<NPC>();
        foreach (NPC npc in npcs) {
            if (npc.GetRoom() == room.GetType()) {
                roomNPCs.Add(npc);
            }
        }
        return roomNPCs;
    }
}