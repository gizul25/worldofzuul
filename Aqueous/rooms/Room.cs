namespace Aqueous;

public abstract class Room
{
    public Dictionary<Direction, Room> Exits { get; } = new();
    public Room? Vent { get; private set; }

    /// Returns the display name of the room
    public virtual string GetName()
    {
        return "unimplemented";
    }

    /// Returns long description of the room
    public virtual string GetDescription()
    {
        return "unimplemented";
    }

    /// Set room links for navigation
    public void SetExits(Room? north, Room? east, Room? south, Room? west)
    {
        SetExit(Direction.North, north);
        SetExit(Direction.East, east);
        SetExit(Direction.South, south);
        SetExit(Direction.West, west);
    }

    /// Set room link for specific direction
    public void SetExit(Direction direction, Room? neighbor)
    {
        if (neighbor == null)
        {
            Exits.Remove(direction);
            return;
        }
        Exits[direction] = neighbor;
    }

    /// Set vent link to specific room
    public void SetVent(Room? ventExit)
    {
        Vent = ventExit;
    }
}
