namespace Aqueous;

public class PetCat : Action {
    public PetCat() {
        Enable();
    }
    
    public override string GetName() {
        return "Pet the Cat";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Disable();
        Console.WriteLine("Petting Leonardo...");
    }
}