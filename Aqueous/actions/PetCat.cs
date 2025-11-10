namespace Aqueous;

public class PetCat : Action {
    public override string GetName() {
        return "Pet the Cat";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Petting Leonardo...");
    }
}