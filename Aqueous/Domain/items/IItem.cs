namespace Aqueous.Domain;

public interface IItem
{
    /// Returns the display name of the item
    string GetName();
    /// Returns a short description of the item
    string GetDescription();
}