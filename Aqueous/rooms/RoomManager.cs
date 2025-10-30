using Aqueous;

public class RoomManager {
    public static Room CreateRooms() {
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


        return crewCabin;
    }
}