namespace Aqueous;

public class QuestManager {
    static IQuest[] allQuests = [
        new MainStoryline(),
    ];

    public IQuest GetQuest(Type type) {
        foreach(IQuest quest in allQuests) {
            if (quest.GetType() == type) {
                return quest;
            }
        }
        throw new Exception("Quest not found.");
    }
}