namespace Aqueous;

public class Cafeteria : Room {
    public override string GetName() {
        return "Cafeteria";
    }

    public override string GetDescription() {
        return @"The heart of the station – the Cafeteria. 
Tables and chairs create a maze on the tiled floor, the fluorescent light making the room seem more clinical than inviting. 
The cook is notoriously grumpy and the food mediocre but it keeps everyone alive enough to work.";
    }
}