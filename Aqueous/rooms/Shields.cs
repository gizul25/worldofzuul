namespace Aqueous;

public class Shields : Room{
    public override string GetName() {
        return "Shields";
    }
    
    public override string GetDescription() {
        return @"The station’s shields. The place you least understand. 
The researchers sometimes talk about radiation and pollution but you never get anything from their rapid-fire jargon.
Your job is to make sure the system is stable and protecting the station like it should.";
    }
}