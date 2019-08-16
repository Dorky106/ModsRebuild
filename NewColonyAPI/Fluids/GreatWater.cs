using BlockEntities;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Types;

namespace PhentrixGames.NewColonyAPI.Fluids
{
    [TypesManager.NCAPIType]
    [BlockEntityAutoLoader]
    internal class GreatWater : Types.BaseType, IUpdatedAdjacentType, ISingleBlockEntityMapping
    {
        public GreatWater() : base("GreatWater", false)
        {
            this.IsPlaceable = false;
            this.SideAll = "greatwater";
            this.BlocksPathing = false;
            if (MeshManager.GetMesh(NewColonyAPIEntry.ModName, "block", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.CollidePlayer = false;
            this.IsSolid = false;
            this.IsDestructible = false;
            this.OnRemoveAmount = 0;
            this.UseHeightMap = true;
            this.UseNormalMap = true;
        }

        public ItemTypes.ItemType TypeToRegister => ItemTypes.GetType(ItemTypes.IndexLookup.GetIndex(TypeName));

        public void OnUpdateAdjacent(AdjacentUpdateData data)
        {
            /*
			if (data.NewType != BlockTypes.BuiltinBlocks.Types.air)
				return;

			if (data.OldType.ItemIndex == Managers.FluidManager.Water.source || data.OldType.ItemIndex == Managers.FluidManager.Water.fake)
				return;

			Vector3Int pos = Managers.FluidManager.ClosestSource(data.ChangePosition);
			if (pos != Vector3Int.maximum)
				Managers.FluidManager.Spread(pos);
			*/
        }
    }
}