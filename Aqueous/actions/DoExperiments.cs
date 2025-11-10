using System.Linq.Expressions;

namespace Aqueous;

public class DoExperiments : Action {
    public DoExperiments()
    {
        Enable();
    }
    
    public override string GetName() {
        return "Experiment";
    }

    public override Type GetRoom()
    {
        return typeof(MainLab);
    }
    
    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override bool IsActive(GameState state)
    {
        if(!base.IsActive(state))
        {
            return false;
        }

        return true;
    }

    public override void Perform(GameState state) {
        base.Perform(state);
        Console.WriteLine("Experimenting on things....");

        while (true)
        {
            Console.Write("Mix chemicals: ");
            int[] array = new int[5];
            int[] validAnswer = { 4, 2, 1, 3, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                // Console.Read() only reads one character and returns int as ASCII number
                array[i] = Console.Read() - '0';
                // Skip whitespace or newline
                Console.Read();
            }

            if (array.SequenceEqual(validAnswer))
            {
                Console.WriteLine("Good job. Maybe I should take advantage of you more often.");
                Complete();
                break;
            }
            else
            {
                Console.WriteLine("Hm, this doesn’t seem right. Could you try again? Maybe listen to my intructions this time, why don’t you?");
            }
        }
        Console.WriteLine("Added blood sample");
        state.itemManager.AddItem(new BloodSample());
    }
}