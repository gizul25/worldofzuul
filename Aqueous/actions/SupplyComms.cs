
namespace Aqueous;

public class SupplyComms : Action
{
    public SupplyComms()
    {
        // TODO
        Enable();
    }

    public override string GetName()
    {
        return "Comunication with the suppliers about the new staff ";
    }

    public override Type GetRoom()
    {
        return typeof(Communications);
    }

    public override Type? GetQuestType()
    {
        return typeof(SideQuests);
    }

    public override void Perform(GameState state)
    { base.Perform(state);
        Console.WriteLine("Barton : We need more staff for the marine reasearchfrom our mysterious suppliers , be careful and chose wisely , it might be dangerous ");
        Console.WriteLine("Barton : We need one microscope and 14 watch glasses and 10 gloves");
        Console.WriteLine("Barton : Please choose two differents companies to order the items from: ");
        
List<string> companies = new List<string> 
{ 
    "1) The Aquanova", 
    "2 ) Coral Mind", 
    "3 ) Blue Horizon Biotech", 
    "4) Natalious" 
};
Console.WriteLine("Please choose two  of the following companies to order the items from : ");

 
 foreach(string company in companies)
 {
Console.WriteLine(company);
 }
bool Aquanova =  false;
bool Natalious =  false;

while (true)
 {
string input = Console.ReadLine();

 if (input == "The Aquanova")
    {
    Console.WriteLine("Your have ordered a microscope 25XM. Expect delivery within 3-5 business days.");
    Aquanova = true ; 
    }
else if (input == "Natalious")
    {
    Console.WriteLine("You have ordered 14 watch glasses and 10 gloves. Expect delivery within 3-5 business days.");
    Natalious = true ; 
     }
 else
{
 Console.WriteLine("The company you selected is not contain the items you need. Please choose a different company.");  
}

if (Aquanova && Natalious)
            {
                Console.WriteLine("Thank you for ordering from both companies. We appreciate your time and effort.");
                break;
            }

}

        Complete();
        state.actionManager.GetAction<DoExperiments>().Enable();
    }
}
        