namespace Aqueous;

public class SecurityKey : IItem {
    public string GetName() {
        return "Security key";
    }

    public string GetDescription() {
        return "Unlocks access to security cameras";
    }
}