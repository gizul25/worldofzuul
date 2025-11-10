namespace Aqueous;

public class MapCommand : SimpleCommand {
    public override string GetName() {
        return "map";
    }

    public override void Run(GameState state) {
        string map = @"
                                                       Crew Cabin --- Elevator
                                                       (Entrance)
                                                           |
                           Security                        |
                              |                            |
                              |                            |      
                      -----  Upper  ---  MedBay ----- Cafeteria --------
                      |      Engine                        |           |
                      |       |                            |           |
                      |       |                            |           |
Cooling system ----Reactor    |                        Sleeping     Primary
                      |       |                        quarters     Research
                      |       |                            |
                      |       |                            | 
                      ----  Lower   --------- Storage---  Main --- Shields
                            Engine               |        Lab         |
                              |                  |         |          |
                              |               Delivery     |      Emergency 
                          Electrical                       |        Escape
                                                           |
                                                    Communications

";
        Console.Write(map);
    }
}