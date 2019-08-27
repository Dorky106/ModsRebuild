using BlockEntities;
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.NewColonyAPI.Content.Powerlines
{
    [NCAPIPowerType]
    [BlockEntityAutoLoader]
    public class PowerLineBase : Types.BaseType, IUpdatedAdjacentType, ISingleBlockEntityMapping
    {
        public PowerLineBase() : base("PowerLineBase", false)
        {
            if (MeshManager.GetMesh(NewColonyAPIEntry.ModName, "newpowerlinebase", out string mesh))
            {
                this.Mesh = mesh;
            }

            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(NewColonyAPIEntry.ModIconDirectory, "powerlinebase.png");

            PowerManager.ValidateBlockID(this.TypeName, new PowerLine(this.TypeName));
        }

        public ItemTypes.ItemType TypeToRegister => ItemTypes.GetType(ItemTypes.IndexLookup.GetIndex(this.TypeName));

        public void OnUpdateAdjacent(AdjacentUpdateData data)
        {
            if (ItemTypes.IndexLookup.GetName(data.NewType.ItemIndex).Contains("PowerLineBase"))
            {
                ServerManager.TryChangeBlock(data.ChangePosition + data.UpdatePositionOffset, UpdateBlocks.UpdateBlockAt(data.ChangePosition + data.UpdatePositionOffset, "PowerLineBase"));
            }
        }
    }
}