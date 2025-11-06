namespace Aqueous;

public class DoExperiments : Action {
    public override string GetName() {
        return "Experiment";
    }

    public override Type GetRoom() {
        return typeof(MainLab);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Experimenting on things....");
    }
}