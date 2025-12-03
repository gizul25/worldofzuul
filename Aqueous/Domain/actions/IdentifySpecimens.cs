namespace Aqueous.Domain;

class IdentifySpecimens : Action
{
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
        base.Perform(state);
        // Source: https://onlineexammaker.com/kb/30-dolphin-trivia-quiz-questions-answers/
        Console.WriteLine("Time for a trivia question.");
        Console.WriteLine("Which type of dolphin is well-known for its distinctive black and white coloration and is often seen in marine parks and aquariums?");
        Console.WriteLine("A. Common dolphin");
        Console.WriteLine("B. Bottlenose dolphin");
        Console.WriteLine("C. Spinner dolphin");
        Console.WriteLine("D. Dusky dolphin");

        bool done = false;
        while (!done)
        {
            string? input = Console.ReadLine();
            switch (input)
            {
                case "A":
                    Console.WriteLine("Incorrect!");
                    break;
                case "B":
                    Console.WriteLine("Correct!");
                    done = true;
                    break;
                case "C":
                    Console.WriteLine("Incorrect!");
                    break;
                case "D":
                    Console.WriteLine("Incorrect!");
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
        }
        Complete();
    }

}