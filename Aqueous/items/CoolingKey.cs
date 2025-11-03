namespace Aqueous;

public class CoolingKey : IItem {
    public string GetName() {
        return "Cooling key";
    }

    public string GetDescription() {
        return "Unlocks the cooling room";
    }
}