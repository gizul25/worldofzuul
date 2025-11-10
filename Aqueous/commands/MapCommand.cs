namespace Aqueous;

public class MapCommand : SimpleCommand {
    public override string GetName() {
        return "map";
    }

    public override void Run(GameState state) {
        string map = @"
Cooling system ----Reactor


more map here
";
        Console.Write(map);
    }
}