namespace Aqueous;

public class RoomManager {
    List<Room> rooms = new List<Room>();

    /// Initializes rooms, their links and vents. Returns starting room.
    public RoomManager() {
        Room crewCabin = new CrewCabin();
        Room cafeteria = new Cafeteria();
        Room elevator = new Elevator();
        Room medBay = new MedBay();
        Room primaryResearch = new PrimaryResearch();
        Room sleepingQuarters = new SleepingQuarters();
        Room mainLab = new MainLab();
        Room upperEngine = new UpperEngine();
        Room lowerEngine = new LowerEngine();
        Room reactor = new Reactor();
        Room security = new Security();
        Room coolingSystem = new CoolingSystem();
        Room electrical = new Electrical();
        Room storage = new Storage();
        Room delivery = new Delivery();
        Room communications = new Communications();
        Room shields = new Shields();
        Room emergencyEscape = new EmergencyExit();


        crewCabin.SetExits(null, elevator, cafeteria, null);
        elevator.SetExits(null, null, null, crewCabin);
        cafeteria.SetExits(crewCabin, primaryResearch, sleepingQuarters, medBay);
        primaryResearch.SetExits(null, null, null, cafeteria);
        medBay.SetExits(null, cafeteria, null, upperEngine);
        sleepingQuarters.SetExits(cafeteria, null, mainLab, null);
        mainLab.SetExits(sleepingQuarters, shields, communications, storage);
        communications.SetExits(mainLab, null, null, null);
        shields.SetExits(null, null, emergencyEscape, mainLab);
        emergencyEscape.SetExits(shields, null, null, null);
        storage.SetExits(null, mainLab, delivery, lowerEngine);
        delivery.SetExits(storage, null, null, null);
        upperEngine.SetExits(security, medBay, lowerEngine, reactor);
        lowerEngine.SetExits(upperEngine, storage, electrical, reactor);
        electrical.SetExits(lowerEngine, null, null, null);
        security.SetExits(null, null, upperEngine, null);
        reactor.SetExits(upperEngine, null, lowerEngine, coolingSystem);
        coolingSystem.SetExits(null, reactor, null, null);

        cafeteria.SetVent(electrical);
        electrical.SetVent(cafeteria);

        crewCabin.SetVent(primaryResearch);
        primaryResearch.SetVent(crewCabin);

        medBay.SetVent(storage);
        storage.SetVent(medBay);

        sleepingQuarters.SetVent(emergencyEscape);
        emergencyEscape.SetVent(sleepingQuarters);

        reactor.SetVent(security);
        security.SetVent(reactor);

        shields.SetVent(communications);
        communications.SetVent(shields);

        delivery.SetVent(lowerEngine);
        lowerEngine.SetVent(delivery);

        upperEngine.SetVent(coolingSystem);
        coolingSystem.SetVent(upperEngine);

        elevator.SetVent(mainLab);
        mainLab.SetVent(elevator);

        rooms.Add(crewCabin);
        rooms.Add(cafeteria);
        rooms.Add(elevator);
        rooms.Add(medBay);
        rooms.Add(primaryResearch);
        rooms.Add(sleepingQuarters);
        rooms.Add(mainLab);
        rooms.Add(upperEngine);
        rooms.Add(lowerEngine);
        rooms.Add(reactor);
        rooms.Add(security);
        rooms.Add(coolingSystem);
        rooms.Add(electrical);
        rooms.Add(storage);
        rooms.Add(delivery);
        rooms.Add(communications);
        rooms.Add(shields);
        rooms.Add(emergencyEscape);
    }

    public Room GetRoom(Type roomType) {
        foreach (Room room in rooms) {
            if (room.GetType() == roomType) {
                return room;
            }
        }
        throw new Exception("Room not found.");
    }

    public Room GetStartingRoom() {
        return GetRoom(typeof(CrewCabin));
    }
}