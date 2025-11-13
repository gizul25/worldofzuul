namespace Aqueous;

public class SleepingQuarters : Room {
    public override string GetName() {
        return "Sleeping Quarters";
    }

    public override string GetDescription() {
        return @"So quiet in here... 
Nobody should be here at this hour, yet you notice a human-sized lump on one of the beds.
Seems like someone slept through their alarm again…";
    }
}