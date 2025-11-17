
namespace Aqueous;

public class Comunications : Action {
    public Comunications()
    {
        Enable();
    }
    
    public override string GetName()
    {
        return "Comunication with the suppliers about the new staff ";
    }

    public override Type GetRoom()
    {
        return typeof(Comunications);
    }
    
    public override Type? GetQuestType()
    {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state)
     {
        base.Perform(state);
        Console.WriteLine("Barton: We need more staff for the marine reasearchfrom our mysterious suppliers , be careful and chose wisely , it might be dangerous ");
        Console.WriteLine("We need one microscope and 14 watch glasses and 10 gloves");
        
List<string> companies = new List<string> 
{ 
    "The Aquanova", 
    "Coral Mind", 
    "Blue Horizon Biotech", 
    "Natalious" 
};
Console.WriteLine("Please choose one of the following companies to order the items from: ");

 foreach(string company in companies)
 {
Console.WriteLine(company);
 }
 string input = Console.ReadLine();

if (input.Equals("The Aquanova", StringComparison.OrdinalIgnoreCase))
        {
    Console.WriteLine("Your have ordered a microscope 25XM. Expect delivery within 3-5 business days.");
        }
    else if (input .Equals("Natalious",StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("You have ordered 14 watch glasses and 10 gloves. Expect delivery within 3-5 business days.");
        }
        else
        {
            Console.WriteLine("The company you selected is not contain the items you need. Please choose a different company.");
        }
  Console.WriteLine(" you for order the items , we appreciate your time and effort");
       Complete();
    

    }
}