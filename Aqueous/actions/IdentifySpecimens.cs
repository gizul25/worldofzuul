namespace Aqueous;

class IdentifySpecimens : Action
{

    public IdentifySpecimens()
    {
        Enable();
    }

    public override string GetName()
    {
        return "Identify the unknown specimen";
    }

    public override Type GetRoom()
    {
        return typeof(PrimaryResearch);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    {

        //TODO: Fill in with a real trivia question, that requires to discern certain species by a key trait 

        base.Perform(state);
        Console.WriteLine("Insert a multiple-choice question here");
        string? input = Console.ReadLine();
        switch (input)
        {
            case "A":
                Console.WriteLine("Incorrect!");
                break;
            case "B":
                Console.WriteLine("Correct!");
                break;
            case "C":
                Console.WriteLine("Incorrect!");
                break;
            default:
                Console.WriteLine("Wrong Input!");
                this.Perform(state);
                break;
        }
    }

}