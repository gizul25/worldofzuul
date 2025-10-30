namespace Aqueous;

public enum Direction {
    North,
    East,
    South,
    West
}

public class DirectionHelper {
    public static Direction DirectionFromString(string direction) {
        switch (direction) {
            case "north":
                return Direction.North;
            case "east":
                return Direction.East;
            case "south":
                return Direction.South;
            case "west":
                return Direction.West;
            default:
                throw new Exception("string is not a direction");
        }
    }
}
