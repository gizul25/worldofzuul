using System.Text.Json.Serialization;

namespace Aqueous.Domain;

[JsonDerivedType(typeof(BallOfFluff), typeDiscriminator: "BallOfFluff")]
[JsonDerivedType(typeof(BloodSample), typeDiscriminator: "BloodSample")]
[JsonDerivedType(typeof(Leftovers), typeDiscriminator: "Leftovers")]
[JsonDerivedType(typeof(SecurityKey), typeDiscriminator: "SecurityKey")]
public abstract class Item
{
    /// Returns the display name of the item
    public abstract string GetName();
    /// Returns a short description of the item
    public abstract string GetDescription();
}