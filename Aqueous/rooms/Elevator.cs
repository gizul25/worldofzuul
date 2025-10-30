namespace Aqueous;

public class Elevator : Room {
    public override string GetName() {
        return "Elevator";
    }

    public override string GetDescription() {
        return "This is the elevator ";
    }
}