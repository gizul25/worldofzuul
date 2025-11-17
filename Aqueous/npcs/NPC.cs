namespace Aqueous;

public class NPC
{
    /// Returns the display name of the NPC
    public virtual string GetName()
    {
        return "unimplemented";
    }

    /// Returns the job title of the NPC. Only used visually.
    public virtual string GetJobTitle()
    {
        return "unimplemented";
    }

    /// Returns the type of the room NPC is located at. Used
    /// to only print NPC's presence in this room.
    public virtual Type GetRoom()
    {
        return typeof(Room);
    }
}