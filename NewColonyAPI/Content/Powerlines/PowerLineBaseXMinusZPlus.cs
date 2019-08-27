using BlockEntities;
using PhentrixGames.NewColonyAPI.Content.Powerlines;
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.NewColonyAPI.Content.Powerlines
{
    [NCAPIPowerType]
    [BlockEntityAutoLoader]
    public class PowerLineBaseXMinusZPlus : Types.BaseType, IUpdatedAdjacentType, ISingleBlockEntityMapping
    {
        public PowerLineBaseXMinusZPlus() : base("PowerLineBaseXMinusZPlus", false)
        {
            if (MeshManager.GetMesh(NewColonyAPIEntry.ModName, "newpowerlinel", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.MeshRotationEuler = new Pipliz.Vector3Int(180, 0, 0);

            this.IsPlaceable = true;
            this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops("PowerLineBase", 1, 1) };
            PowerManager.ValidateBlockID(this.TypeName, new PowerLine(this.TypeName));
        }

        public ItemTypes.ItemType TypeToRegister => ItemTypes.GetType(ItemTypes.IndexLookup.GetIndex(TypeName));

        public void OnUpdateAdjacent(AdjacentUpdateData data)
        {
            ServerManager.TryChangeBlock(data.ChangePosition + data.UpdatePositionOffset, UpdateBlocks.UpdateBlockAt(data.ChangePosition + data.UpdatePositionOffset, "PowerLineBase"));
        }
    }
}