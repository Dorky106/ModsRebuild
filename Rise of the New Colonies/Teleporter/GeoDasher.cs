using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.Teleporter
{
    [NCAPIPowerRecipe]
    public class GeoDasherBlockRecipe : BaseRecipe
    {
        public GeoDasherBlockRecipe() : base("GeoDasherRecipe", null, true)
        {
            this.Requirements = new System.Collections.Generic.List<InventoryItem>()
            {
                new InventoryItem("PowerLineBase", 10),
                new InventoryItem("ironingot", 25)
            };

            this.Result = new System.Collections.Generic.List<InventoryItem>()
            {
                new InventoryItem("Geo Dasher", 1)
            };
        }
    }

    [NCAPIPowerType]
    public class GeoDasherBlock : BaseType
    {
        public GeoDasherBlock() : base("Geo Dasher", false)
        {
            this.IsPlaceable = true;
            this.IsRotatable = true;
            this.RotatableXMinus = "Geo Dasherx-";
            this.RotatableXPlus = "Geo Dasherx+";
            this.RotatableZMinus = "Geo Dasherz-";
            this.RotatableZPlus = "Geo Dasherz+";
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "geodasher.png");
            if (MeshManager.GetMesh(Entry.ModName, "gate", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }

    [NCAPIPowerType]
    public class GeoDasherBlockXPlus : BaseType
    {
        public GeoDasherBlockXPlus() : base("Geo Dasherx+", false)
        {
            this.IsPlaceable = true;
            this.ParentType = "Geo Dasher";
            PowerManager.ValidateBlockID(base.TypeName, new GeoDasher());
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
            /*
			NewColonyAPI.Data.TypeColliderData typeColliderData = new NewColonyAPI.Data.TypeColliderData();
			typeColliderData.bounds = new System.Collections.Generic.List<Pipliz.BoundsPip>()
			{
				new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
			};
			this.Colliders = typeColliderData;
			*/
            this.Colliders = new System.Collections.Generic.List<Pipliz.BoundsPip>()
            {
                new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
            };
        }
    }

    [NCAPIPowerType]
    public class GeoDasherBlockXMinus : BaseType
    {
        public GeoDasherBlockXMinus() : base("Geo Dasherx-", false)
        {
            this.IsPlaceable = true;
            this.ParentType = "Geo Dasher";
            PowerManager.ValidateBlockID(base.TypeName, new GeoDasher());
            /*
			NewColonyAPI.Data.TypeColliderData typeColliderData = new NewColonyAPI.Data.TypeColliderData();
			typeColliderData.bounds = new System.Collections.Generic.List<Pipliz.BoundsPip>()
			{
				new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
			};
			this.Colliders = typeColliderData;
			*/
            this.Colliders = new System.Collections.Generic.List<Pipliz.BoundsPip>()
            {
                new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
            };
        }
    }

    [NCAPIPowerType]
    public class GeoDasherBlockZPlus : BaseType
    {
        public GeoDasherBlockZPlus() : base("Geo Dasherz+", false)
        {
            this.IsPlaceable = true;
            this.ParentType = "Geo Dasher";
            PowerManager.ValidateBlockID(base.TypeName, new GeoDasher());
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
            /*
			NewColonyAPI.Data.TypeColliderData typeColliderData = new NewColonyAPI.Data.TypeColliderData();
			typeColliderData.bounds = new System.Collections.Generic.List<Pipliz.BoundsPip>()
			{
				new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
			};
			this.Colliders = typeColliderData;
			*/
            this.Colliders = new System.Collections.Generic.List<Pipliz.BoundsPip>()
            {
                new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
            };
        }
    }

    [NCAPIPowerType]
    public class GeoDasherBlockZMinus : BaseType
    {
        public GeoDasherBlockZMinus() : base("Geo Dasherz-", false)
        {
            this.IsPlaceable = true;
            this.ParentType = "Geo Dasher";
            PowerManager.ValidateBlockID(base.TypeName, new GeoDasher());
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
            /*
			NewColonyAPI.Data.TypeColliderData typeColliderData = new NewColonyAPI.Data.TypeColliderData();
			typeColliderData.bounds = new System.Collections.Generic.List<Pipliz.BoundsPip>()
			{
				new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
			};
			this.Colliders = typeColliderData;
			*/
            this.Colliders = new System.Collections.Generic.List<Pipliz.BoundsPip>()
            {
                new Pipliz.BoundsPip(new UnityEngine.Vector3(-.75f,-.5f,-.75f), new UnityEngine.Vector3(.75f,2.5f,.75f))
            };
        }
    }

    public class GeoDasher : Machine
    {
        public GeoDasher() : base("GeoDasher", 2000, 1000)
        {
        }
    }
}