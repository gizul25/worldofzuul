namespace Aqueous.Domain;

public class QuestManager
{
    static IQuest[] allQuests = [
        new MainStoryline(),
        new SideQuests(),
    ];

    /// Returns quest instance given type of a quest
    public IQuest GetQuest(Type type)
    {
        foreach (IQuest quest in allQuests)
        {
            if (quest.GetType() == type)
            {
                return quest;
            }
        }
        throw new Exception("Quest not found.");
    }
}