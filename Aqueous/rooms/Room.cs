namespace Aqueous
{
    public class Room
    {
        public Dictionary<Direction, Room> Exits { get; private set; } = new();
        public Room? Vent { get; private set; }

        public virtual string GetName() {
            return "unimplemented";
        }

        public virtual string GetDescription() {
            return "unimplemented";
        }

        public void SetExits(Room? north, Room? east, Room? south, Room? west)
        {
            SetExit(Direction.North, north);
            SetExit(Direction.East, east);
            SetExit(Direction.South, south);
            SetExit(Direction.West, west);
        }

        public void SetExit(Direction direction, Room? neighbor)
        {
            if (neighbor == null) {
                Exits.Remove(direction);
                return;
            }
            Exits[direction] = neighbor;
        }

        public void SetVent(Room? ventExit) {
            Vent = ventExit;
        }
    }
}
