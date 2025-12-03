using System.Text.Json.Serialization;

namespace Aqueous.Domain;

[JsonDerivedType(typeof(AdjustReactorTemp), typeDiscriminator: "AdjustReactorTemp")]
[JsonDerivedType(typeof(CheckCoralReefStatus), typeDiscriminator: "CheckCoralReefStatus")]
[JsonDerivedType(typeof(CheckingOnMeds), typeDiscriminator: "CheckingOnMeds")]
[JsonDerivedType(typeof(CollectMarineFloraSamples), typeDiscriminator: "CollectMarineFloraSamples")]
[JsonDerivedType(typeof(DecontaminateFishSamples), typeDiscriminator: "DecontaminateFishSamples")]
[JsonDerivedType(typeof(DoExperiments), typeDiscriminator: "DoExperiments")]
[JsonDerivedType(typeof(DoResearch), typeDiscriminator: "DoResearch")]
[JsonDerivedType(typeof(EatFood), typeDiscriminator: "EatFood")]
[JsonDerivedType(typeof(FeedMickey), typeDiscriminator: "FeedMickey")]
[JsonDerivedType(typeof(FeedTheCat), typeDiscriminator: "FeedTheCat")]
[JsonDerivedType(typeof(FixWiringAction), typeDiscriminator: "FixWiringAction")]
[JsonDerivedType(typeof(IdentifySpecimens), typeDiscriminator: "IdentifySpecimens")]
[JsonDerivedType(typeof(PetCat), typeDiscriminator: "PetCat")]
[JsonDerivedType(typeof(RationsCheckUp), typeDiscriminator: "RationsCheckUp")]
[JsonDerivedType(typeof(RatTrapCoolingSystem), typeDiscriminator: "RatTrapCoolingSystem")]
[JsonDerivedType(typeof(RatTrapCrewCabin), typeDiscriminator: "RatTrapCrewCabin")]
[JsonDerivedType(typeof(RatTrapDelivery), typeDiscriminator: "RatTrapDelivery")]
[JsonDerivedType(typeof(RatTrapShields), typeDiscriminator: "RatTrapShields")]
[JsonDerivedType(typeof(RatTrapStorage), typeDiscriminator: "RatTrapStorage")]
[JsonDerivedType(typeof(SecurityCheck), typeDiscriminator: "SecurityCheck")]
[JsonDerivedType(typeof(ShieldMaintenance), typeDiscriminator: "ShieldMaintenance")]
[JsonDerivedType(typeof(Sleep), typeDiscriminator: "Sleep")]
[JsonDerivedType(typeof(Socialize), typeDiscriminator: "Socialize")]
[JsonDerivedType(typeof(StoreWaterSamples), typeDiscriminator: "StoreWaterSamples")]
[JsonDerivedType(typeof(SupplyComms), typeDiscriminator: "SupplyComms")]
[JsonDerivedType(typeof(TalkToJoey), typeDiscriminator: "TalkToJoey")]
[JsonDerivedType(typeof(TalkToJoey2), typeDiscriminator: "TalkToJoey2")]
[JsonDerivedType(typeof(TalkToSteve), typeDiscriminator: "TalkToSteve")]
[JsonDerivedType(typeof(TalkToViktor), typeDiscriminator: "TalkToViktor")]
[JsonDerivedType(typeof(UploadResearchData), typeDiscriminator: "UploadResearchData")]

public abstract class Action
{
    /// Controls if the action can perform check should even run in the first
    /// place. Used to enable/disable new actions after completing some of them.
    [JsonInclude]
    private bool isEnabled = false;

    /// Used for different endings
    [JsonInclude]
    public bool IsCompleted { get; private set; } = false;

    /// Returns display name of the action
    public virtual string GetName()
    {
        return "unimplemented";
    }

    /// Returns the type of the room in which the action is located and needs
    /// to be performed
    public virtual Type GetRoom()
    {
        return typeof(Room);
    }

    /// Returns the type of the quest this action is part of. `null` if action
    /// is not included in any quest.
    public virtual Type? GetQuestType()
    {
        return null;
    }

    /// Checks if action can be performed when this action is enabled. Generally
    /// this function should not be modified and `IsActive()` should be changed.
    public virtual bool CanPerform(GameState state)
    {
        if (!IsActive(state))
        {
            return false;
        }
        return state.CurrentRoom.GetType() == GetRoom();
    }

    /// Returns if the action could be performed if player would be in the room.
    /// This is the place to implement item checks or other conditional checks.
    /// Note that enabled check and room check are done by this parent class.
    /// Don't forget to call `base.IsActive()` if overriding this function.
    public virtual bool IsActive(GameState state)
    {
        return isEnabled;
    }

    /// Enables this action to be performed. Use this for unlocking new actions
    /// in the questline after completing another action.
    public void Enable()
    {
        isEnabled = true;
    }

    /// Disables this action. Use this to prevent this action to be completed
    /// multiple times. Generally should be called from `Perform()`.
    public void Disable()
    {
        isEnabled = false;
    }

    /// Used to mark this action as completed. Separate from disable for multiple
    /// part actions.
    public void Complete()
    {
        Disable();
        IsCompleted = true;
    }

    /// A function which is called to execute the action when it is guaranteed
    /// it meets all action requirements to run
    public virtual void Perform(GameState state) { }
}