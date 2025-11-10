namespace Aqueous;

public class FeedTheCat : Action {
    public FeedTheCat() {
        Enable();
    }

    public override string GetName() {
        return "Feed the cat";
    }

    public override Type GetRoom() {
        return typeof(Cafeteria);
    }

    public override Type? GetQuestType() {
        return typeof(MainStoryline);
    }

    public override void Perform(GameState state) {
        Console.WriteLine("Good job, you got the ball of fluff to like you more. Beware of jealous researchers...");
    }
}