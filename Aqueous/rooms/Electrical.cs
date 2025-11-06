namespace Aqueous;

public class Electrical : Room {
    public override string GetName() {
        return "Electrical";
    }

    public override string GetDescription() {
        return @"The walls are covered in wires and sensors. 
You see a hunched man working in the corner. 
It’s Joseph the electrician, better not disturb him.";
    }
}