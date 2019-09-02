using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Generators
{
    [NCAPIPowerRecipe]
    public class HydroGeneratorRecipe : BaseRecipe
    {
        public HydroGeneratorRecipe() : base("HydroGeneratorRecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("copper", 50),
                new InventoryItem("ironingot", 5)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Hydro Generator")
            };
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlock : BaseType
    {
        public HydroGeneratorBlock() : base("Hydro Generator", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "hydro.png");

            if (MeshManager.GetMesh(Entry.ModName, "hydro", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.IsRotatable = true;
            this.RotatableXMinus = "Hydro GeneratorX-";
            this.RotatableXPlus = "Hydro GeneratorX+";
            this.RotatableZMinus = "Hydro GeneratorZ-";
            this.RotatableZPlus = "Hydro GeneratorZ+";

            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockXMinus : BaseType
    {
        public HydroGeneratorBlockXMinus() : base("Hydro GeneratorX-", false)
        {
            this.ParentType = "Hydro Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockXPlus : BaseType
    {
        public HydroGeneratorBlockXPlus() : base("Hydro GeneratorX+", false)
        {
            this.ParentType = "Hydro Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockZMinus : BaseType
    {
        public HydroGeneratorBlockZMinus() : base("Hydro GeneratorZ-", false)
        {
            this.ParentType = "Hydro Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 0, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockZPlus : BaseType
    {
        public HydroGeneratorBlockZPlus() : base("Hydro GeneratorZ+", false)
        {
            this.ParentType = "Hydro Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockLit : BaseType
    {
        public HydroGeneratorBlockLit() : base("Hydro GeneratorLit", false)
        {
            this.IsPlaceable = true;

            this.IsRotatable = true;
            this.RotatableXMinus = "Hydro GeneratorLitX-";
            this.RotatableXPlus = "Hydro GeneratorLitX+";
            this.RotatableZMinus = "Hydro GeneratorLitZ-";
            this.RotatableZPlus = "Hydro GeneratorLitZ+";

            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
            this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops("Hydro Generator", 1, 1) };
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockLitXMinus : BaseType
    {
        public HydroGeneratorBlockLitXMinus() : base("Hydro GeneratorLitX-", false)
        {
            this.ParentType = "Hydro GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockLitXPlus : BaseType
    {
        public HydroGeneratorBlockLitXPlus() : base("Hydro GeneratorLitX+", false)
        {
            this.ParentType = "Hydro GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockLitZMinus : BaseType
    {
        public HydroGeneratorBlockLitZMinus() : base("Hydro GeneratorLitZ-", false)
        {
            this.ParentType = "Hydro GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 0, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    [NCAPIPowerType]
    public class HydroGeneratorBlockLitZPlus : BaseType
    {
        public HydroGeneratorBlockLitZPlus() : base("Hydro GeneratorLitZ+", false)
        {
            this.ParentType = "Hydro GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
            PowerManager.ValidateBlockID(this.TypeName, new HydroGenerator());
        }
    }

    public class HydroGenerator : Generator
    {
        public HydroGenerator() : base("Hydro Generator", 200, 2)
        {
        }
    }
}