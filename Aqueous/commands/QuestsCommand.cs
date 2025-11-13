namespace Aqueous;

public class QuestsCommand : SimpleCommand {
    public override string GetName() {
        return "quests";
    }

    public override void Run(GameState state) {
        List<Action> actions = state.actionManager.GetCurrentQuestActions(state);
        if (actions.Count == 0) {
            Console.WriteLine("No quests");
            return;
        }

        foreach (Action action in actions) {
            Type? questType = action.GetQuestType();
            // Won't happen, here just to please the compiler
            if (questType == null) {
                continue;
            }
            IQuest quest = state.questManager.GetQuest(questType);
            // Won't happen, here just to please the compiler
            if (quest == null) {
                continue;
            }

            Room room = state.roomManager.GetRoom(action.GetRoom());

            Console.WriteLine($"\x1b[33m{quest.GetName()} - {action.GetName()} [{room.GetName()}]\x1b[0m");
        }
    }
}