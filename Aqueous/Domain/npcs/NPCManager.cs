namespace Aqueous.Domain;

public class NPCManager
{
    private static NPC[] npcs = [
        new CommunicationOfficer(),
        new Doctor(),
        new Electrician(),
        new Janitor(),
        new MarineMedic(),
        new Mechanic(),
        new Overseer(),
        new SecurityGuard(),
        new SeniorLabManager(),
        new SickResearcher(),
        new SoftwareEngineer(),
        new StationCook(),
        new StationCat(),
        new StationBiologist(),
        new StorageManager()
    ];

    /// Returns a list of NPCs in a given room
    public List<NPC> GetRoomNPCs(Room room)
    {
        List<NPC> roomNPCs = new List<NPC>();
        foreach (NPC npc in npcs)
        {
            if (npc.GetRoom() == room.GetType())
            {
                roomNPCs.Add(npc);
            }
        }
        return roomNPCs;
    }
}