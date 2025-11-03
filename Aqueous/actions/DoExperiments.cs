namespace Aqueous;

public class DoExperiments : Action {
    public override string GetName() {
        return "Experiment";
    }

    public override bool CanPerform(GameState state) {
        return state.CurrentRoom is MainLab;
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Experimenting on things....");
    }
}