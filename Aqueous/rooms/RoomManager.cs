using Aqueous;

public class RoomManager {
    public static Room CreateRooms() {
        Room crewCabin = new CrewCabin();
        Room cafeteria = new Cafeteria();
        
        crewCabin.SetExit(Direction.South, cafeteria);
        cafeteria.SetExit(Direction.North, crewCabin);

        return crewCabin;
    }
}