using System.Linq.Expressions;

namespace Aqueous;

public class DoExperiments : Action
{
    public DoExperiments()
    {
        Enable();
    }

    public override string GetName()
    {
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
        if (!base.IsActive(state))
        {
            return false;
        }

        return true;
    }

    public override void Perform(GameState state)
    {
        base.Perform(state);
        Console.WriteLine("Helen: “Oh, you're here. Good. You'll help make some medicine for Mickey. Here, take these vials and mix them in this order.” Helen points at the vials - fourth, second, first, third and fifth respectively.");
        Console.WriteLine("You grab a few vials and a bunch of extra equipment. Your hands are stlightly shaky as you carefully mix the solutions.");
        Console.WriteLine("Thankfully those particular chemicals won't explode if you mix them wrong. At least they shouldn't.");

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
                Console.WriteLine("Helen: “Good job. Maybe I should take advantage of you more often.”");
                Complete();
                break;
            }
            else
            {
                Console.WriteLine("Helen: “Hm, this doesn’t seem right. Could you try again? Maybe listen to my intructions this time, why don’t you?”");
            }
        }
        Console.WriteLine("You got Mickey's blood sample. Maybe one of the researchers needs it?");
        state.itemManager.AddItem(new BloodSample());
    }
}