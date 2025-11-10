namespace Aqueous;

public class CheckingOnMeds : Action {
    public CheckingOnMeds()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Check on medical equipment";
    }

    public override Type GetRoom() {
        return typeof(MedBay);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Complete();
        Console.WriteLine("Checking on medical equipment....");
        
    }
}